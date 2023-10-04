namespace Distribuited.Services.Interaction.Dto;

public record ServiceTypeDto(string Description,
                             DateTime CreatedAt,
                             bool Active,
                             string Code,
                             JobCount JobsCount,
                             int[] Charges);


