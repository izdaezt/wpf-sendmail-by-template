namespace SharedKernel;

public static class DataErrors
{
    public static Error NotFound(string dataName, int dataId) => Error.NotFound(
        $"{dataName}.NotFound",
        $"The {dataName} item with the Id = '{dataId}' was not found");

    public static Error NotFound(string dataName, string dataKey) => Error.NotFound(
        $"{dataName}.NotFound",
        $"The {dataName} item with the Key = '{dataKey}' was not found");

    public static Error Failure(string dataName, string value) => Error.Failure(
        $"{dataName}.Failure",
        $"The {dataName} item with the Value = '{value}' was failure");

    public static Error Forbidden(string dataName, string dataKey) => Error.Forbidden(
        $"{dataName}.Forbidden",
        $"The {dataName} item with the Key = '{dataKey}' was not permission");

    public static Error Problem(string dataName, string problem) => Error.Problem(
        $"{dataName}.Invalid",
        $"{problem}");

    public static Error Conflict(string dataName, string problem) => Error.Conflict(
        $"{dataName}.Conflict",
        $"{problem}");
}
