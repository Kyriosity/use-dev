namespace WizConstr.Blocks;

public interface INoLnkLeft;
public interface INoLnkRight;

public interface ILnkLeft;
public interface ILnkRight;

public interface ILnkLeftOnly : ILnkLeft, INoLnkRight;
public interface ILnkRightOnly : ILnkRight, INoLnkLeft;
public interface ILnkLeftRight : ILnkLeft, ILnkRight;