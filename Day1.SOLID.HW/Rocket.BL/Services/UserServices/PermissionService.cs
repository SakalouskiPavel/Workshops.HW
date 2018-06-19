using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using AutoMapper;
using Common.Logging;
using Microsoft.AspNet.Identity;
using Rocket.BL.Common.Enums;
using Rocket.BL.Common.Models.UserRoles;
using Rocket.DAL.Common.DbModels.Identity;
using Rocket.DAL.Common.UoW;
using Rocket.DAL.Identity;

namespace Rocket.BL.Services.UserServices
{
    /// <summary>
    /// Добавление/удаление пермишенов у ролей + логирование
    /// </summary>
    public class PermissionService : BaseService //, IPermissionService
    {
        private readonly RocketUserManager _userManager;

        private readonly RockeRoleManager _roleManager;

        private readonly ILog _logger;

        private readonly string _claimName = "permission";

        /// <summary>
        /// Создает новый экземпляр <see cref="PermissionService"/>
        /// с заданным unit of work
        /// </summary>
        /// <param name="unitOfWork">Экземпляр unit of work</param>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        /// <param name="logger"></param>
        public PermissionService(IUnitOfWork unitOfWork, RocketUserManager userManager,
            RockeRoleManager roleManager, ILog logger) : base(unitOfWork)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        /// <summary>
        /// Добавляет пермишен роли
        /// </summary>
        /// <param name="idRole">Идентификатор роли</param>
        /// <param name="idPermission">Идентификатор пермишена</param>
        public void AddPermissionToRole(string idRole, int idPermission)
        {
            var dbRole = _unitOfWork.RoleRepository.GetById(idRole);
            var dbPermission = _unitOfWork.PermissionRepository.GetById(idPermission);
            dbRole.Permissions.Add(dbPermission);
            _unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Удоляет пермишен у роли
        /// </summary>
        /// <param name="idRole">Идентификатор роли</param>
        /// <param name="idPermission">Идентификатор пермишена</param>
        public void RemovePermissionFromRole(string idRole, int idPermission)
        {
            var dbRole = _unitOfWork.RoleRepository.GetById(idRole);
            var dbPermission = _unitOfWork.PermissionRepository.GetById(idPermission);
            dbRole.Permissions.Remove(dbPermission);
            _unitOfWork.SaveChanges();
        }
        

        /// <summary>
        /// Добавляет пермишен
        /// </summary>
        /// <param name="permission">Пермишен</param>
        public void InsertPermission(Permission permission, string user)
        {
            var permPermissionId = new Claim("permission", permission.Id.ToString());
            var permValueName = new Claim("ValueName", permission.ValueName);
            var permDescription = new Claim("Description", permission.Description);

            _userManager.AddClaim(user, permValueName);
            _userManager.AddClaim(user, permDescription);

            _logger.Debug($"Permission {permission.Description} added in DB");

            var dbPermission = Mapper.Map<DbPermission>(permission);
            _unitOfWork.PermissionRepository.Insert(dbPermission);

            _unitOfWork.SaveChanges();
        }

        
        /// <summary>
        /// Обновляет пермишен
        /// </summary>
        /// <param name="permission">Пермишен</param>
        public void Update(Permission permission, string user)
        {
            var userId = _userManager.FindById(user);

            var claims = _userManager.GetClaimsAsync(userId.ToString());

            var permis = (Claim)claims.Result.FirstOrDefault(a => (a.Type == "ValueName") && (a.Value == permission.ValueName));

            if (permis == null)
            {
                var permValueName = new Claim("ValueName", permission.ValueName);
                var permDescription = new Claim("Description", permission.Description);
                _userManager.AddClaim(user, permValueName);
                _userManager.AddClaim(user, permDescription);
                _logger.Debug($"Permission {permission.Description} added in DB");
            }
            else
            {
                return;
            }

            var dbPermission = Mapper.Map<DbPermission>(permission);
            _unitOfWork.PermissionRepository.Update(dbPermission);
            _unitOfWork.SaveChanges();
        }
        

        /// <summary>
        /// Удаляет пермишен
        /// </summary>
        /// <param name="id">Идентификатор пермишена</param>
        public void Delete(Permission permission, string user)
        {
            var userId = _userManager.FindById(user);

            var claims = _userManager.GetClaimsAsync(userId.ToString());

            var permis = (Claim)claims.Result.FirstOrDefault(a => (a.Type == "ValueName") && (a.Value == permission.ValueName));

            if (permis == null)
            {
                return;
            }
            else
            {
                _userManager.RemoveClaim(user, permis);
            }
        }

        /// <summary>
        /// Возвращает пермешен с заданным идентификатором
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns>Permission</returns>
        public Permission GetById(string id)
        {
            return Mapper.Map<Permission>(_unitOfWork.PermissionRepository.GetById(id));
        }
       

        /// <summary>
        /// Возвращает пермишены роли, нужно для UI
        /// </summary>
        /// <returns>Коллекцию Permission</returns>
        public IEnumerable<Permission> GetAllPermissions()
        {
            var result = (IEnumerable<Permission>)_userManager.Users.SelectMany(u => u.Claims).ToList();
            return result;
        }

        /// <summary>
        /// Возвращает пермишены роли, нужно для UI
        /// </summary>
        /// <param name="idRole">Идентификатор роли</param>
        /// <returns>Коллекцию Permission</returns>
        public IEnumerable<Permission> GetPermissionByUser(string user)
        {
            var userId = _userManager.FindById(user);

            var claims = _userManager.GetClaimsAsync(userId.ToString());

            var permis = (IEnumerable<Permission>)claims.Result;

            return permis;
        }
    }
}