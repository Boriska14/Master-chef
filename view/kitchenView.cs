using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenApp.model;
using KitchenApp.contract;

namespace KitchenApp.view
{
    public class KitchenView : IObserver
    {
        private static int FPS = 25;
        private static int FRAME_RATE = 1000 / FPS;
        public static int SQUARE_SIZE = 64;
        public ControlForm controlForm { get; set; }
        public MonitorForm monitorForm { get; set; }
        public KitchenForm kitchenForm { get; set; }

        public KitchenView(KitchenModel model)
        {
            kitchenForm = new KitchenForm(model);
            controlForm = new ControlForm(kitchenForm);
            monitorForm = new MonitorForm(kitchenForm);
        }

        void IObserver.UpdateHasMoved(int pastX, int pastY, int newX, int newY)
        {
            kitchenForm.Invoke((MethodInvoker)delegate
            {
                kitchenForm.Invalidate(new Rectangle(pastX * SQUARE_SIZE, pastY * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE));
                kitchenForm.Invalidate(new Rectangle(newX * SQUARE_SIZE, newY * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE));
                kitchenForm.Update();
            });
            Thread.Sleep(40);
        }

        void IObserver.UpdateMaterialAvailableChanged(string name)
        {
            switch (name)
            {
                case "blender":
                    monitorForm.Invoke((MethodInvoker)delegate
                    {
                        monitorForm.labelBlenderAvailableNumber.Text = kitchenForm.model.blender.quantity + "";
                        monitorForm.Refresh();
                    });
                    break;
            }
        }

        void IObserver.UpdateEmployeeNotAvailable(string name)
        {
            switch (name)
            {
                case "chef":
                    monitorForm.Invoke((MethodInvoker)delegate
                    {
                        int pastAvailableChefNumber = int.Parse(monitorForm.labelAvailableChefNumber.Text);
                        monitorForm.labelAvailableChefNumber.Text = (pastAvailableChefNumber - 1) + "";
                        monitorForm.Refresh();
                    });
                    break;
            }
        }

        void IObserver.UpdateEmployeeAvailable(string name)
        {
            switch (name)
            {
                case "chef":
                    monitorForm.Invoke((MethodInvoker)delegate
                    {
                        int pastAvailableChefNumber = int.Parse(monitorForm.labelAvailableChefNumber.Text);
                        monitorForm.labelAvailableChefNumber.Text = (pastAvailableChefNumber + 1) + "";
                        monitorForm.Refresh();
                    });
                    break;
            }
        }

        void IObserver.UpdateEvent(string eventName)
        {
            monitorForm.Invoke((MethodInvoker)delegate
            {
                monitorForm.labelEvent.Text = "----------# " + eventName + " #----------";
                monitorForm.Refresh();
            });
        }
    }
}
