using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Invisiblebook.data.Business;
using Invisiblebook.data.Model;
using Invisiblebook.ViewModel;
namespace Invisiblebook
{
    /// <summary>
    /// Here the DI magic come on.
    /// </summary>
    public class Bootstrapper
    {
        public IUnityContainer Container { get; set; }

        public Bootstrapper()
        {
            Container = new UnityContainer();

            ConfigureContainer();
        }

        /// <summary>
        /// We register here every service / interface / viewmodel.
        /// </summary>
        private void ConfigureContainer()
        {
            Container.RegisterInstance<ICategoryRepository>(new CategoryRepository("categories"));
            Container.RegisterInstance<IBookRepository>(new BookRepository("books"));
            Container.RegisterInstance<IChapterRepository>(new ChapterRepository("chapters"));
            Container.RegisterType<MainViewModel>();
        }
    }
}
