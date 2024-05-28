namespace AbcModels.Creatures.Names;

public interface IFamily : IDenom;

// PERSONAGE

// Enum: historical, fictious, real


public enum EduDegree
{
    Undefined = 0,
    None,
    Bachelor, // undergraduate
    PhD
}


//  Timeline DateOnly with Bag !
//  Degree Enum, YEAR  with Bag ! OR TIMELINE ??
// EVENT AS BAG ???

public interface IFamily<T> : IDenom<(T First, T Last)>
{
    //string First { get; } // Works throug param
    //string Last { get; }
}

public interface IFamily_Init : IFamily
{

}

public interface IFamily_Edit : IFamily
{
    new string First { get; set; }
    new string Last { get; set; }
}
