﻿// Modified from https://github.com/OdeToCode/AddFeatureFolders

namespace Dofactory.JS
{
    public static class FlatAreaExtensions
    {
        /// <summary>
        /// Use flat area folders with custom options
        /// </summary>
        public static IMvcBuilder AddFlatAreas(this IMvcBuilder services, FlatAreaOptions options)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            if (options == null)
            {
                throw new ArgumentException(nameof(options));
            }

            var expander = new FlatAreaExpander(options);

            services.AddMvcOptions(o =>
            {
                o.Conventions.Add(new FlatAreaConvention(options));
            })
            .AddRazorOptions(o =>
            {
                // Helps locate shared and other fully qualified resources

                o.ViewLocationFormats.Clear();
                o.ViewLocationFormats.Add(options.AreaPlaceholder + @"\{0}.cshtml");
                o.ViewLocationFormats.Add(options.RootFolderName + @"\_Base\{0}.cshtml");
                o.ViewLocationFormats.Add(options.RootFolderName + @"\_Shared\{0}.cshtml");
                o.ViewLocationFormats.Add(options.RootFolderName + @"\Tutorial\_Shared\{0}.cshtml");
                o.ViewLocationFormats.Add(options.RootFolderName + @"\{0}.cshtml"); 

                o.ViewLocationExpanders.Add(expander);
            });

            return services;
        }

        /// <summary>
        /// Use feature folders with the default options. Controllers and view will be located
        /// under a folder named Features. Shared views are located in Features\Shared.
        /// </summary>
        public static IMvcBuilder AddAreaFolders(this IMvcBuilder services)
        {
            return AddFlatAreas(services, new FlatAreaOptions());
        }
    }
}