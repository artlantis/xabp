﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Collections.Generic;
using System.Threading.Tasks;

using Volo.Abp.TextTemplating;

namespace X.Abp.TextTemplateManagement.TextTemplates;
public interface ITextTemplateDefinitionSerializer
{
    Task<KeyValuePair<TextTemplateDefinitionRecord, List<TextTemplateDefinitionContentRecord>>> SerializeAsync(
      TemplateDefinition template);

    Task<Dictionary<TextTemplateDefinitionRecord, List<TextTemplateDefinitionContentRecord>>> SerializeAsync(
      IEnumerable<TemplateDefinition> templates);
}
