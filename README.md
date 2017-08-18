## AUV
It is a standard definition,designs or specifications to supply other providers . It is small and no other dependencies, and always support the lowest framework.

##Install from nuget
>Install-Package auv

##Latest Version 1.0.0

##Platform Support
* .NET Framework 4.5+
* .NET Standard 1.1+
* .NET Core 1.1+


##Documentation

###Singleton&lt;T>
> T is a class that want to be a singleton instance.

####CreateInstance()

Create a singleton instance from T with safety threading.
****
###DisposableHandler
>It is an abstract class to handle the disposable pattern to implament by IDisposable. To know [disposable pattern](https://msdn.microsoft.com/en-us/library/b1yfkh5e(v=vs.110).aspx).


####DisposeHandler()
It is an abstract method to release unmanage resource by client that had inherited.

####HasDisposed
It is a property to know current object had been disposed or not.

****
###ApplicationResult
>To represent a result of execution after method invoke with custom errors

####Succeeded
To represent current execution had been successed or failed.

####Errors
To represent the errors from failed result.

####Success()
To represent current execution is successed.It is a static method

    return ApplicationResult.Success();

####Failed(params string[] errors), Failed(IEnumerable<string> errors)
To represent current execution is failed, and should have some errors.

    return ApplicationResult.Failed();
    return ApplicationResult.Failed("there is an error");
    return ApplicationResult.Failed("there is an error","there is another error");
    
####Example

    public static ApplicationResult ToDo()
    {
        if(xxxxx)
        {
            return ApplicationResult.Failed("error occured");
        }
        return Application.Success();
    }
    
    //in client
    var result = Class1.ToDo();
    if(!result.IsSucceed)
    {
        //get result.Errors
    }