namespace Distribuited.Services.Interaction.Dto;

public record ChargeTypeDto(int Id,
                            string Description,
                            bool Active,
                            DateTime CreatedAt,                            
                            decimal Value);


