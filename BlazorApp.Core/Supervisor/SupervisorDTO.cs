using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Core{

    public record struct SupervisorDTO(
        /* [Required, StringLength(30)]
        string Name,

        [Required]
        int Id,

        [Required]
        string Description,

        [Required]
        DateTime DueDate,

        [Required]
        int IntendedWorkHours,
        
        [Required]
        Language Language,
        
        ISet<KeywordEnum> Keywords,
        
        [Required]
        string SkillRequirementDescription,

        [Required]
        SupervisorDTO Supervisor,

        [Required]
        ISet<WorkDay> WorkDays,

        [Required]
        ISet<Location> Locations,

        [Required]
        bool isThesis */
    );
}
