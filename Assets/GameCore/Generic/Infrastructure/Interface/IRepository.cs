using System.Collections.Generic;


namespace GameCore.Generic.Infrastructure
{
    /// <summary>
    /// 未來可實作Peer儲存用
    /// http://teddy-chen-tw.blogspot.com/2020/08/10repository.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        T this[string key] { get; set; }
        IEnumerable<string> Keys { get; }
        IEnumerable<T> Values { get; }
        int Count { get; }



        bool Add(string id, T add);

        T AddOrSet(string id, T add, T set);
        bool ContainsId(string id);
        void DeleteAll();
        bool DeleteById(string id);
        T FindById(string id);
        IEnumerable<T> GetAll();
        (bool exist, T entity) GetEntity(string id);
        bool Save(string id, T entity);
    }
}