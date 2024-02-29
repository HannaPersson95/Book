namespace Eksamen_Emne8.Mappers;

public interface IBookMapper<TModel, TDto>
{
    TDto MapToDTO(TModel model);

    TModel MapToModel(TDto dto);


}
