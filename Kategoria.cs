
using System.ComponentModel.DataAnnotations;

namespace infoinfo.Models;
public class Kategoria
{
    [Key] // zbędne jest po nazwie ID
    [Display(Name="identyfikator kategorii")]  
    public int Kategorii { get; set; }
    
    public string NazwaKategorii {  get; set; }
    public string OpisKategorii {  get; set; }   
    public string Ikona { get; set; }
    public bool Aktywna {  get; set; }
    public int Informacja { get; set; }

}
