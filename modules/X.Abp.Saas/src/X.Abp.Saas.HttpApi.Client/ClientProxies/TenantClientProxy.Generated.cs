// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.Saas;
using X.Abp.Saas.Dtos;

// ReSharper disable once CheckNamespace
namespace X.Abp.Saas;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ITenantAppService), typeof(TenantClientProxy))]
public partial class TenantClientProxy : ClientProxyBase<ITenantAppService>, ITenantAppService
{
    public virtual async Task<SaasTenantDto> GetAsync(Guid id)
    {
        return await RequestAsync<SaasTenantDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<PagedResultDto<SaasTenantDto>> GetListAsync(GetTenantsInput input)
    {
        return await RequestAsync<PagedResultDto<SaasTenantDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetTenantsInput), input }
        });
    }

    public virtual async Task<SaasTenantDto> CreateAsync(SaasTenantCreateDto input)
    {
        return await RequestAsync<SaasTenantDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(SaasTenantCreateDto), input }
        });
    }

    public virtual async Task<SaasTenantDto> UpdateAsync(Guid id, SaasTenantUpdateDto input)
    {
        return await RequestAsync<SaasTenantDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(SaasTenantUpdateDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<SaasTenantDatabasesDto> GetDatabasesAsync()
    {
        return await RequestAsync<SaasTenantDatabasesDto>(nameof(GetDatabasesAsync));
    }

    public virtual async Task<SaasTenantConnectionStringsDto> GetConnectionStringsAsync(Guid id)
    {
        return await RequestAsync<SaasTenantConnectionStringsDto>(nameof(GetConnectionStringsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task UpdateConnectionStringsAsync(Guid id, SaasTenantConnectionStringsDto input)
    {
        await RequestAsync(nameof(UpdateConnectionStringsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(SaasTenantConnectionStringsDto), input }
        });
    }

    public virtual async Task ApplyDatabaseMigrationsAsync(Guid id)
    {
        await RequestAsync(nameof(ApplyDatabaseMigrationsAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<List<EditionLookupDto>> GetEditionLookupAsync()
    {
        return await RequestAsync<List<EditionLookupDto>>(nameof(GetEditionLookupAsync));
    }

    public virtual async Task<bool> CheckConnectionStringAsync(string connectionString)
    {
        return await RequestAsync<bool>(nameof(CheckConnectionStringAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), connectionString }
        });
    }

    public virtual async Task SetPasswordAsync(Guid id, SaasTenantSetPasswordDto input)
    {
        await RequestAsync(nameof(SetPasswordAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(SaasTenantSetPasswordDto), input }
        });
    }
}
