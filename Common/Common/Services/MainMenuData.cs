using Common.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Common.Services
{
    public class MainMenuData
    {
        public static ObservableCollection<MainMenu> MainMenuOptions = new ObservableCollection<MainMenu>
        {
            new MainMenu
            {
                MenuItemId =1,
                ImageName ="ActivityTracking_MenuItem.png",
                Title ="Activity Tracking",
                Description ="What are you working on right now",
                //Color ="#ffffff"
                Color ="Purple"
            },
            new MainMenu
            {
                MenuItemId =2,
                ImageName ="OffWork_MenuItem.png",
                Title ="Off Work",
                Description ="Take a break from the office!",
                //Color ="#ffffff"
                Color ="Green"
            },
            new MainMenu
            {
                MenuItemId =3,
                ImageName ="SuccessAndDevelopment_MenuItem.png",
                Title ="Success And Development",
                Description ="Build our mission together!",
                Color ="#ffffff"
            },
            new MainMenu
            {
                MenuItemId =4,
                ImageName ="TalentHunt_MenuItem.png",
                Title ="Talent Hunt",
                Description ="Team work makes the team work",
                Color ="#ffffff"
            },
            new MainMenu
            {
                MenuItemId =5,
                ImageName ="MyRewards_MenuItems.png",
                Title ="My Rewards",
                Description ="What makes Definity First great",
                Color ="#ffffff"
            },
            new MainMenu
            {
                MenuItemId =6,
                ImageName ="UsefulTips_MenuItem.png",
                Title ="Useful Tips",
                Description ="Learn all about us right here",
                Color ="#ffffff"
            }
            ,
            new MainMenu
            {
                MenuItemId =7,
                ImageName ="TalentHunt_MenuItem.png",
                Title ="Lorem ipsum",
                Description ="Lorem ipsum dolor sit",
                Color ="#ffffff"
            }
            ,
            new MainMenu
            {
                MenuItemId =8,
                ImageName ="OffWork_MenuItem.png",
                Title ="Lorem ipsum",
                Description ="Lorem ipsum dolor sit amet",
                Color ="#ffffff"
            }
        };
    }
}
