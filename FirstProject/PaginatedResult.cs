using System;
using System.Collections.Generic;

namespace FirstProject;

public interface IEntity 
{
    int Id { get; set; }
}
public class Reastaurant : IEntity 
{
    public int Id { get; set; }
}

public class User : IEntity
{
    public string Name { get; set; }
    public int Id { get; set; }
}

public class PaginatedResult<T>
{
    public List<T> Results { get; set; }
    public int ResultsFrom { get; set; }
    public int ResultsTo { get; set; }
    public int TotalPages { get; set; }
    public int TotalResults { get; set; }
}
