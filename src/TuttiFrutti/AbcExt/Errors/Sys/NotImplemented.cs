﻿namespace AbcExt.Errors.Sys;
public class NotImplemented : AbcException<NotImplementedException>
{
    private NotImplemented() { /* to prevent direct instantiation */ }

    public static dynamic ToDo(string message) => true;
}

