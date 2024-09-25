﻿using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace X.Abp.Quartz.Blazor.Menus;

public class QuartzMenuContributor : IMenuContributor
{
  public virtual async Task ConfigureMenuAsync(MenuConfigurationContext context)
  {
    if (context.Menu.Name == StandardMenus.Main)
    {
      await ConfigureMainMenuAsync(context);
    }
  }

  private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
  {
    //Add main menu items.
    context.Menu.AddItem(new ApplicationMenuItem(QuartzMenus.Prefix, displayName: "Quartz", "/Quartz", icon: "fa fa-globe"));

    return Task.CompletedTask;
  }
}
