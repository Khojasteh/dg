﻿// Copyright (c) 2019 Kambiz Khojasteh
// Released under the MIT software license, see the accompanying
// file LICENSE.txt or http://www.opensource.org/licenses/mit-license.php.

using Document.Generator.Languages;
using System;
using System.Collections.Generic;

namespace Document.Generator.Config
{
    public class Settings
    {
        public ICollection<string> AssemblyFiles { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public string OutputFolder { get; set; } = "./";

        public bool FlattenFolder { get; set; } = false;

        public string IndexName { get; set; } = null;

        public Language Language => CSharp.Instance;

        public MarkdownOptions Markdown { get; set; } = new MarkdownOptions { Enabled = true };

        public HtmlOptions Html { get; set; } = new HtmlOptions { Enabled = false };

        public IEnumerable<FormatOptions> OutputFormats
        {
            get
            {
                if (Markdown.Enabled)
                    yield return Markdown;
                if (Html.Enabled)
                    yield return Html;
            }
        }
    }
}
