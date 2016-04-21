﻿using IdentityCompletoNHibernate.Mappings;
using IdentityCompletoNHibernate.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace IdentityCompletoNHibernate.App_Start.Identity
{
    //Configurando o RoleManager utilizado na aplicação.
    public class ApplicationRoleManager : RoleManager<IdentityRole>
    {
        public ApplicationRoleManager(IRoleStore<IdentityRole, string> roleStore)
            : base(roleStore)
        {
        }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            return new ApplicationRoleManager(new RoleStore<IdentityRole>(new UnitOfWork().Session));
        }
    }
}