﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace X.Abp.CmsKit.Pro.Admin.Web.Menus;

public class AbpCmsKitProAdminMenuContributor : IMenuContributor
{
  public virtual async Task ConfigureMenuAsync(MenuConfigurationContext context)
  {
    if (context.Menu.Name == StandardMenus.Main)
    {
      await ConfigureMainMenuAsync(context);
    }
  }

  private static Task ConfigureMainMenuAsync(MenuConfigurationContext context)
  {
    // Add main menu items.
    context.Menu.AddItem(new ApplicationMenuItem(AbpCmsKitProAdminMenus.Prefix, displayName: "Admin", "~/Admin", icon: "fa fa-globe"));

    return Task.CompletedTask;
  }
}
