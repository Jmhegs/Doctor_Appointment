using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Doctor_Appointment.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string? PatientName { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Appointment Date and Time")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Patient's Payment")]
        public decimal Payment { get; set; }

        [DisplayName("Doctor's Full Name")]
        public string? DoctorName { get; set; }

        [Range(1, 10)]
        [DisplayName("Patient's Perceived Level of Pain (1 low to 10 High")]
        public int PainLevel { get; set; }

    }
}
