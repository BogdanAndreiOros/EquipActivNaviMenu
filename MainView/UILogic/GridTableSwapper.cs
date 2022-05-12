namespace MainView.UILogic
{
    public class GridTableSwapper
    {
        public int ActivityGridIndex { get; private set; } = 2;
        public int EquipmentGridIndex { get; private set; } = 1;

        public void SwapGridToEquipmentTable()
        {
            ActivityGridIndex = 2;
            EquipmentGridIndex = 1;
        }

        public void SwapGridToActivityTable()
        {
            ActivityGridIndex = 1;
            EquipmentGridIndex = 2;
        }

    }
}
