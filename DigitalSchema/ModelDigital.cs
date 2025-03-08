namespace DigitalSchema.Models
{
    public class ModelDigital
    {
        public bool SwitchOne { get; set; }
        public bool SwitchTwo { get; set; }
        public ModelDigital(bool s_values)
        {
            SwitchOne = s_values;
            SwitchTwo = s_values;
        }
    }
}
