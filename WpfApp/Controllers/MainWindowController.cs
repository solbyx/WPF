using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WpfApp.Controllers
{
    internal class MainWindowController
    {
        private readonly ICollectionView _view;
        private readonly MainWindow _mainWindow;

        public MainWindowController(MainWindow mainWindow, ICollectionView views)
        {
            _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
            _view = views ?? throw new ArgumentNullException(nameof(views));
        }
    }
}