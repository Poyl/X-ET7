//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace ET
{
   
[Config]
public partial class LocalizeConfig_Excel_ENCategory: ConfigSingleton<LocalizeConfig_Excel_ENCategory>
{
    private readonly Dictionary<string, LocalizeConfig_EN> _dataMap;
    private readonly List<LocalizeConfig_EN> _dataList;
    
    public LocalizeConfig_Excel_ENCategory(ByteBuf _buf)
    {
        _dataMap = new Dictionary<string, LocalizeConfig_EN>();
        _dataList = new List<LocalizeConfig_EN>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            LocalizeConfig_EN _v;
            _v = LocalizeConfig_EN.DeserializeLocalizeConfig_EN(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Key, _v);
        }
        PostInit();
    }
    
    public bool Contain(string id)
    {
        return _dataMap.ContainsKey(id);
    }

    public Dictionary<string, LocalizeConfig_EN> GetAll()
    {
        return _dataMap;
    }
    
    public List<LocalizeConfig_EN> DataList => _dataList;

    public LocalizeConfig_EN GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public LocalizeConfig_EN Get(string key) => _dataMap[key];
    public LocalizeConfig_EN this[string key] => _dataMap[key];

    public override void Resolve(Dictionary<string, IConfigSingleton> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    public override void TrimExcess()
    {
        _dataMap.TrimExcess();
        _dataList.TrimExcess();
    }
    
    
    public override string ConfigName()
    {
        return typeof(LocalizeConfig_EN).Name;
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}