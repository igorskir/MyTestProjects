namespace ComboBoxDataBinding
{
    public class ComboBoxItemString
    {
        public string ValueString { get; set; }
   
    }

    public class ComboBoxItemColor
    {
        public ViewModelEnum.Colors ValueColorEnum { get; set; }
        public string ValueColorString { get; set; }
    }
}
