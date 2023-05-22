namespace Rvrs;
public interface IBackForth : IBack, IForth { }
public interface IBackForthTimed : IBackTimed, IForthTimed { }
public interface IBackForthConditional<T> : IBackConditional<T>, IForthConditional<T> { }

public interface IBack_Timed : IBack, IBackTimed { }
public interface IBackForth_Timed : IBackForth, IBackForthTimed { }

public interface IBack_Conditional<T> : IBack, IBackConditional<T> { }
public interface IBack_AllIn<T> : IBack_Timed, IBackConditional<T> { }

public interface IBackForth_AllIn<T> : IBack_AllIn<T>, IForth, IForthTimed, IForthConditional<T> { }
