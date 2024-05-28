namespace AbcModels.Creatures.Names;
public interface IWestern : IFamily
{

    string Middle { get; }

    // ToDo: AcademicDegree Degree; // Dr. | Prof. | Dipl. Engineer | PhD
}

public interface IWestern_Init : IWestern, IFamily_Init
{
    new string Middle { get; init; }
}

public interface IWestern_Edit : IWestern, IFamily_Edit
{
    new string Middle { get; set; }
}

