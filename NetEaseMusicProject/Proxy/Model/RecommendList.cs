using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Model
{
    

public class Creator
{
    public bool defaultAvatar { get; set; }
    public int province { get; set; }
    public int authStatus { get; set; }
    public bool followed { get; set; }
    public string avatarUrl { get; set; }
    public int accountStatus { get; set; }
    public int gender { get; set; }
    public int city { get; set; }
    public object birthday { get; set; }
    public int userId { get; set; }
    public int userType { get; set; }
    public string nickname { get; set; }
    public string signature { get; set; }
    public string description { get; set; }
    public string detailDescription { get; set; }
    public object avatarImgId { get; set; }
    public object backgroundImgId { get; set; }
    public string backgroundUrl { get; set; }
    public int authority { get; set; }
    public bool mutual { get; set; }
    public List<string> expertTags { get; set; }
    public Experts experts { get; set; }
    public int djStatus { get; set; }
    public int vipType { get; set; }
    public object remarkName { get; set; }
    public string avatarImgIdStr { get; set; }
    public string backgroundImgIdStr { get; set; }
    public string avatarImgId_str { get; set; }
}

public class Subscriber
{
    public bool defaultAvatar { get; set; }
    public int province { get; set; }
    public int authStatus { get; set; }
    public bool followed { get; set; }
    public string avatarUrl { get; set; }
    public int accountStatus { get; set; }
    public int gender { get; set; }
    public int city { get; set; }
    public object birthday { get; set; }
    public int userId { get; set; }
    public int userType { get; set; }
    public string nickname { get; set; }
    public string signature { get; set; }
    public string description { get; set; }
    public string detailDescription { get; set; }
    public object avatarImgId { get; set; }
    public object backgroundImgId { get; set; }
    public string backgroundUrl { get; set; }
    public int authority { get; set; }
    public bool mutual { get; set; }
    public object expertTags { get; set; }
    public object experts { get; set; }
    public int djStatus { get; set; }
    public int vipType { get; set; }
    public object remarkName { get; set; }
    public string avatarImgIdStr { get; set; }
    public string backgroundImgIdStr { get; set; }
    public string avatarImgId_str { get; set; }
}

public class Playlist
{
    public string name { get; set; }
    public long? id { get; set; }
    public long? trackNumberUpdateTime { get; set; }
    public int? status { get; set; }
    public int? userId { get; set; }
    public long? createTime { get; set; }
    public long? updateTime { get; set; }
    public int? subscribedCount { get; set; }
    public int? trackCount { get; set; }
    public int? cloudTrackCount { get; set; }
    public string coverImgUrl { get; set; }
    public long? coverImgId { get; set; }
    public string description { get; set; }
    public List<string> tags { get; set; }
    public int? playCount { get; set; }
    public long? trackUpdateTime { get; set; }
    public int? specialType { get; set; }
    public int? totalDuration { get; set; }
    public Creator creator { get; set; }
    public object tracks { get; set; }
    public List<Subscriber> subscribers { get; set; }
    public bool? subscribed { get; set; }
    public string commentThreadId { get; set; }
    public bool? newImported { get; set; }
    public int? adType { get; set; }
    public bool? highQuality { get; set; }
    public int? privacy { get; set; }
    public bool? ordered { get; set; }
    public bool? anonimous { get; set; }
    public int? shareCount { get; set; }
    public string coverImgId_str { get; set; }
    public int? commentCount { get; set; }
    public string copywriter { get; set; }
    public string tag { get; set; }
}

public class RecommendListObject
{
    public ObservableCollection<Playlist> playlists { get; set; }
    public int code { get; set; }
    public bool more { get; set; }
    public long lasttime { get; set; }
    public int total { get; set; }
}}
