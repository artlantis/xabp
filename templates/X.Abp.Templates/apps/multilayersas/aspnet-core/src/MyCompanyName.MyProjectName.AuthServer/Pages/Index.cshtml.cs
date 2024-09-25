﻿#if IdentityServer4
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.IdentityServer.Clients;
using Volo.Abp.Localization;

namespace MyCompanyName.MyProjectName.Pages;

public class IndexModel : AbpPageModel
{
    public List<Client>? Clients { get; protected set; }

    public IReadOnlyList<LanguageInfo>? Languages { get; protected set; }

    public string? CurrentLanguage { get; protected set; }

    protected IClientRepository ClientRepository { get; }

    protected ILanguageProvider LanguageProvider { get; }

    public IndexModel(IClientRepository clientRepository, ILanguageProvider languageProvider)
    {
        ClientRepository = clientRepository;
        LanguageProvider = languageProvider;
    }

    public async Task OnGetAsync()
    {
        Clients = await ClientRepository.GetListAsync();

        Languages = await LanguageProvider.GetLanguagesAsync();
        CurrentLanguage = CultureInfo.CurrentCulture.DisplayName;
    }
}

#else
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Localization;
using Volo.Abp.OpenIddict.Applications;

namespace MyCompanyName.MyProjectName.Pages;

public class IndexModel : AbpPageModel
{
    public List<OpenIddictApplication>? Applications { get; protected set; }

    public IReadOnlyList<LanguageInfo>? Languages { get; protected set; }

    public string? CurrentLanguage { get; protected set; }

    protected IOpenIddictApplicationRepository OpenIdApplicationRepository { get; }

    protected ILanguageProvider LanguageProvider { get; }

    public IndexModel(IOpenIddictApplicationRepository openIdApplicationRepository, ILanguageProvider languageProvider)
    {
        OpenIdApplicationRepository = openIdApplicationRepository;
        LanguageProvider = languageProvider;
    }

    public async Task OnGetAsync()
    {
        Applications = await OpenIdApplicationRepository.GetListAsync();

        Languages = await LanguageProvider.GetLanguagesAsync();
        CurrentLanguage = CultureInfo.CurrentCulture.DisplayName;
    }
}
#endif
