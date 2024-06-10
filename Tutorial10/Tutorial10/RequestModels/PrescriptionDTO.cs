using Tutorial10.Models;

namespace Tutorial10.RequestModels;

public class PrescriptionDTO
{
    public Patient Patient { get; set; }
    public List<Medicament> Medicaments { get; set; } 
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }

}