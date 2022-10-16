namespace Modbus_RTU_With_ASP.Net_MVC_Sample.Models.DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Day
    {
        [Key]
        public int Stt { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Time_Stamp { get; set; }

        public double? Voltage_1 { get; set; }

        public double? Voltage_2 { get; set; }

        public double? Voltage_3 { get; set; }

        public double? Voltage_Average { get; set; }

        public double? Current_1 { get; set; }

        public double? Current_2 { get; set; }

        public double? Current_3 { get; set; }

        public double? Current_Phase_N { get; set; }

        public double? Current_Average { get; set; }

        public double? Frequency_Average { get; set; }

        public double? PF_1 { get; set; }

        public double? PF_2 { get; set; }

        public double? PF_3 { get; set; }

        public double? PF_Average { get; set; }

        public double? Integral_Active_Power_1 { get; set; }

        public double? Integral_Active_Power_2 { get; set; }

        public double? Integral_Active_Power_3 { get; set; }

        public double? Total_Integral_Active_Power { get; set; }

        public double? Instantaneous_Active_Power_1 { get; set; }

        public double? Instantaneous_Active_Power_2 { get; set; }

        public double? Instantaneous_Active_Power_3 { get; set; }

        public double? Total_Instantaneous_Active_Power { get; set; }
    }
}
