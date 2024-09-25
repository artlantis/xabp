/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module auditLogging

(function(){

  // controller x.abp.auditLogging.auditLogs

  (function(){

    abp.utils.createNamespace(window, 'x.abp.auditLogging.auditLogs');

    x.abp.auditLogging.auditLogs.getList = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs' + abp.utils.buildQueryString([{ name: 'startTime', value: input.startTime }, { name: 'endTime', value: input.endTime }, { name: 'url', value: input.url }, { name: 'clientId', value: input.clientId }, { name: 'userId', value: input.userId }, { name: 'userName', value: input.userName }, { name: 'applicationName', value: input.applicationName }, { name: 'clientIpAddress', value: input.clientIpAddress }, { name: 'correlationId', value: input.correlationId }, { name: 'httpMethod', value: input.httpMethod }, { name: 'httpStatusCode', value: input.httpStatusCode }, { name: 'maxExecutionDuration', value: input.maxExecutionDuration }, { name: 'minExecutionDuration', value: input.minExecutionDuration }, { name: 'hasException', value: input.hasException }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.get = function(id, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/' + id + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.getErrorRate = function(filter, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/statistics/error-rate' + abp.utils.buildQueryString([{ name: 'startDate', value: filter.startDate }, { name: 'endDate', value: filter.endDate }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.getAverageExecutionDurationPerDay = function(filter, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/statistics/average-execution-duration-per-day' + abp.utils.buildQueryString([{ name: 'startDate', value: filter.startDate }, { name: 'endDate', value: filter.endDate }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.getEntityChanges = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/entity-changes' + abp.utils.buildQueryString([{ name: 'auditLogId', value: input.auditLogId }, { name: 'entityChangeType', value: input.entityChangeType }, { name: 'entityId', value: input.entityId }, { name: 'entityTypeFullName', value: input.entityTypeFullName }, { name: 'startDate', value: input.startDate }, { name: 'endDate', value: input.endDate }, { name: 'sorting', value: input.sorting }, { name: 'skipCount', value: input.skipCount }, { name: 'maxResultCount', value: input.maxResultCount }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.getEntityChangesWithUsername = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/entity-changes-with-username' + abp.utils.buildQueryString([{ name: 'entityId', value: input.entityId }, { name: 'entityTypeFullName', value: input.entityTypeFullName }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.getEntityChangeWithUsername = function(entityChangeId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/entity-change-with-username/' + entityChangeId + '',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogs.getEntityChange = function(entityChangeId, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/audit-logs/entity-changes/' + entityChangeId + '',
        type: 'GET'
      }, ajaxParams));
    };

  })();

  // controller x.abp.auditLogging.auditLogSettings

  (function(){

    abp.utils.createNamespace(window, 'x.abp.auditLogging.auditLogSettings');

    x.abp.auditLogging.auditLogSettings.get = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/settings',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogSettings.update = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/settings',
        type: 'PUT',
        dataType: null,
        data: JSON.stringify(input)
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogSettings.getGlobal = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/settings/global',
        type: 'GET'
      }, ajaxParams));
    };

    x.abp.auditLogging.auditLogSettings.updateGlobal = function(input, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/audit-logging/settings/global',
        type: 'PUT',
        dataType: null,
        data: JSON.stringify(input)
      }, ajaxParams));
    };

  })();

})();


