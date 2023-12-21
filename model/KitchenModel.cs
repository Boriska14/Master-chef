using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenApp.contract;

namespace KitchenApp.model
{
    public class KitchenModel
    {
        public List<IObserver> observers { get; set; }

        public Kitchen kitchen { get; set; }

        public KitchenMaterial cookingFire { get; set; }

        public KitchenMaterial oven { get; set; }

        public KitchenMaterial blender { get; set; }

        public KitchenMaterial pan { get; set; }

        public KitchenMaterial kitchenKnife { get; set; }

        public Recipe[] recipes { get; set; }

        public Chef[] chefs { get; set; }

        public PartChef[] partChefs { get; set; }

        public KitchenClerk[] clerks { get; set; }

        public Washer[] washers { get; set; }


        public KitchenModel()
        {
            kitchen = new Kitchen();
            observers = new List<IObserver>();


            cookingFire = KitchenMaterialFactory.CreateCookingFire();
            oven = KitchenMaterialFactory.CreateOven();
            blender = KitchenMaterialFactory.CreateBlender();
            pan = KitchenMaterialFactory.CreatePan();
            kitchenKnife = KitchenMaterialFactory.CreateKitchenKnife();

            recipes = new Recipe[1]
            {
                new Recipe
                (
                    "Feuilleté au crabe",

                    new Commodity[4]
                    {
                        new Commodity("pâte feuilletée"),
                        new Commodity("oeuf"),
                        new Commodity("sel"),
                        new Commodity("poivre")
                    },

                    new RecipeTask[3]
                    {
                        new RecipeTask("Préchauffer le four à 230°", 5, oven),
                        new RecipeTask("Mélanger crabe, citron, chapelure, herbes", 1, blender),
                        new RecipeTask("Lier le tout avec un oeuf", 1, kitchenKnife)
                    }
                ),

            };

            SetEmployeeConfig(1, 2, 5, 1);
            SetMaterialConfig(10, 1, 2, 10, 5);

        }

        public void SetEmployeeConfig(int chefNumber, int partChefNumber, int kitchenClerkNumber, int washerNumber)
        {
            chefs = new Chef[chefNumber];
            partChefs = new PartChef[partChefNumber];
            clerks = new KitchenClerk[kitchenClerkNumber];
            washers = new Washer[washerNumber];

            for (int i = 0; i < chefs.Length; i++)
            {
                chefs[i] = new Chef();
                chefs[i].y = i;
            }

            for (int i = 0; i < partChefs.Length; i++)
            {
                PartChef partChef = new()
                {
                    x = 1,
                    y = i + 1
                };


                if (i % 2 != 0)
                {
                    partChef.currentSprite = partChef.GetSprite("moving-down");
                }

                partChefs[i] = partChef;
            }

            for (int i = 0; i < clerks.Length; i++)
            {
                clerks[i] = new();
                clerks[i].x = 0;
                clerks[i].y = i + 2;
            }

            for (int i = 0; i < washers.Length; i++)
            {
                washers[i] = new Washer();
            }
        }
        public void SetMaterialConfig(int cookingFireNumber, int ovenNumber, int blenderNumber, int panNumber, int kitchenKnifeNumber)
        {
            cookingFire.quantity = cookingFireNumber;
            oven.quantity = ovenNumber;
            blender.quantity = blenderNumber;
            pan.quantity = panNumber;
            kitchenKnife.quantity = kitchenKnifeNumber;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyHasMoved(int pastX, int pastY, int newX, int newY)
        {
            foreach (IObserver observer in observers)
            {
                observer.UpdateHasMoved(pastX, pastY, newX, newY);
            }
        }

        public void NotifyMaterialAvailableChanged(String name)
        {
            foreach (IObserver observer in observers)
            {
                observer.UpdateMaterialAvailableChanged(name);
            }
        }

        public void NotifyEmployeeTaskChanged(String name, String taskName)
        {
            foreach (IObserver observer in observers)
            {
                //observer.UpdateMaterialAvailableChanged(name, taskName);
            }
        }        

        public void NotifyEmployeeAvailable(String name)
        {
            foreach (IObserver observer in observers)
            {
                observer.UpdateEmployeeAvailable(name);
            }
        }

        public void NotifyEmployeeNotAvailable(String name)
        {
            foreach (IObserver observer in observers)
            {
                observer.UpdateEmployeeNotAvailable(name);
            }
        }

        public void NotifyEvent(String eventName)
        {
            foreach (IObserver observer in observers)
            {
                observer.UpdateEvent(eventName);
            }
        }

    }
}
