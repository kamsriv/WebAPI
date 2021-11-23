interface ICommon
{
    string Message { get; set; }
    bool IsSuccess { get; set; }
    void SetError(string msg);
    void SetSuccess(string msg);
    void SetSuccess<T>(string msg) where T : class;
    void SetError<T>(string msg) where T : class;
}
