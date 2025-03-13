namespace WizConstr.Blocks;

public interface INoFnLeft;
public interface INoFnRight;

public interface IFnLeft;
public interface IFnRight;

public interface IFnLeftOnly : IFnLeft, INoFnRight;
public interface IFnRightOnly : IFnRight, INoFnLeft;
public interface IFnLeftRight : IFnLeft, IFnRight;