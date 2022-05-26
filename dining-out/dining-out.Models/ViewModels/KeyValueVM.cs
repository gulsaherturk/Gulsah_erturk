using System;
namespace dining_out.Models.ViewModels
{
    public partial class KeyValueVM
    {
        public KeyValueVM(string key,String value)
        {
            this.Key = key;
            this.Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}

