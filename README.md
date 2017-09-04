## AUV
It is a standard definition,designs or specifications to supply other providers . It is small and no other dependencies, and always support the lowest framework.

定义各种其他提供引擎的基本接口和设计，可以下载其他组件进行最终实现。通过最小接口和设计，可以很容易的更换实现。

## Install From Nuget（从 Nuget 进行安装）
>Install-Package auv

## Latest Version 1.0.1（最新版本）
* [fix] ApplicationResult&lt;T> that cannot invode method properly;
* [修复]ApplicationResult&lt;T> 无法正确调用问题；

****
* .NET Framework 4.5+
* .NET Standard 1.1+
* .NET Core 1.1+

**please see [Wiki](https://github.com/Williamsoft520/AUV/wiki) to quick start.**

**查看[Wiki](https://github.com/Williamsoft520/AUV/wiki)快速开始**

## Offen Instance(常用实例)

### Singleton&lt;T>
> T is a class that want to be a singleton instance.

> T 是需要进行单例模式的实例类型。 

**CreateInstance()**

Create a singleton instance from T with safety threading.

创建一个具有线程安全的单例实例。

    Singleton<Class>.CreateInstance();

****
### ApplicationResult
>To represent a result of execution after method invoke with custom errors

> 用于表示一个操作结果
> 
#### Example

    public static ApplicationResult ToDo()
    {
        if(xxxxx)
        {
            return ApplicationResult.Failed("error occured");
        }
        return Application.Success();
    }
    
    //in client 调用时
    var result = Class1.ToDo();
    if(!result.IsSucceed)
    {
        // result.Errors
    }
