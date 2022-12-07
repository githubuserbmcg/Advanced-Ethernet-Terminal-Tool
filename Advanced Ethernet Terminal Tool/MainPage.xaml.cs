using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Advanced_Ethernet_Terminal_Tool
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            try
            {
                Categories[0].Children[1].Children.Add(new Category()
                {
                    Name = "Matt's Test System",
                    CategoryIcon = "Home",
                    IsLeaf = true
                });
                this.InitializeComponent();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static string SetIcon(eCategoryIcon eIcon)
        {
            return eIcon.ToString();
        }

        public ObservableCollection<Category> Categories = new ObservableCollection<Category>()
        {
        new Category(){
            Name = "TCP Client",
            CategoryIcon = "Home",
            Children = new ObservableCollection<Category>() {
                new Category(){
                    Name = "Manual Entry",
                    CategoryIcon = "Home",
                   IsLeaf = true
                },
                new Category(){
                    Name = "Addresses Book",
                    CategoryIcon = "Home",
                    Children = new ObservableCollection<Category>() {
                        new Category() {
                            Name  = "Add Entry",
                            CategoryIcon = "Home",
                            IsLeaf = true
                        }
                    }
                },
                new Category(){
                    Name = "Macros",
                    CategoryIcon = "Home",
                    Children = new ObservableCollection<Category>() {
                        new Category() {
                            Name  = "Add Macro",
                            CategoryIcon ="Home",
                            IsLeaf = true
                        }
                    }
                },
            }
        },
        new Category(){
            Name = "TCP Server",
            CategoryIcon = "Home",
            Children = new ObservableCollection<Category>() {
                new Category(){
                    Name = "Configuration",
                    CategoryIcon = "Home",
                    IsLeaf = true
                },
                new Category(){
                    Name = "Macros",
                    CategoryIcon = "Home",
                    Children = new ObservableCollection<Category>() {
                        new Category() {
                            Name  = "Add Macro",
                            CategoryIcon = "Home",
                            IsLeaf = true
                        }
                    }
                },
            }
        },
        new Category(){
            Name = "UDP",
            CategoryIcon = "Home",
            Children = new ObservableCollection<Category>() {
                new Category(){
                    Name = "Configuration",
                    CategoryIcon = "Home",
                    IsLeaf = true
                },
                new Category(){
                    Name = "Macros",
                    CategoryIcon = "Home",
                    Children = new ObservableCollection<Category>() {
                        new Category() {
                            Name  = "Add Macro",
                            CategoryIcon = "Home",
                            IsLeaf = true
                        }
                    }
                },
            }
        }
        };
    }
}
