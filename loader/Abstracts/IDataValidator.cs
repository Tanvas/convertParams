using System;


namespace CourceToWebUC.Model
{
    /// <summary>
    /// интерфейс валидации данных
    /// </summary>
    public interface IDataValidator
    {
        /// <summary>
        /// корректны ли параметры
        /// </summary>
        bool IsParamsValid { get; }
        /// <summary>
        /// сообщение об ошибочном
        /// параметре
        /// </summary>
        string ErrorMessage { get; }
    }
}
