namespace ProyectoIntegrador_Mensajeria.Entities;

public class User
{
    public Guid Id { get; set; } // Identificador único del usuario
    public string Email { get; set; } = string.Empty; // Email único del usuario
    public string PasswordHash { get; set; } = string.Empty; 
    public string Name { get; set; } = string.Empty; 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
    public DateTime? UpdatedAt { get; set; } 

    
}
