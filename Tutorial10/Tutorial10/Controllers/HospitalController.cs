using Microsoft.AspNetCore.Mvc;
using Tutorial10.Repositories;

namespace Tutorial10.Controllers;

public class HospitalController : ControllerBase
{
    private readonly IHospitalRepository _hospitalRepository;

    public HospitalController(IHospitalRepository hospitalRepository)
    {
        _hospitalRepository = hospitalRepository;
    }
    
}