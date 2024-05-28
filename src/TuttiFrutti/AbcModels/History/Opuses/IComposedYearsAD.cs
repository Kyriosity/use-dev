namespace AbcModels.History.Opuses;
public interface IComposedYearsAD : IComposed<short>;
public interface IComposedYearsAD_Init : IComposedYearsAD, IComposed_Init<short>;
public interface IComposedYearsAD_Edit : IComposedYearsAD, IComposed_Edit<short>;
