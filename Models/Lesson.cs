namespace Godot_Learning_WebSite.Models;

public enum LearningTrack
{
    GdScript,
    CSharp,
    Chronos
}

public record Lesson(
    string Slug,
    string Title,
    string Summary,
    LearningTrack Track,
    string Module,
    string Dimension,
    string Stage,
    int Order,
    string ThumbnailTitle,
    string ThumbnailSubtitle,
    string ThumbnailStyle,
    string Status,
    string DateRange,
    decimal? Price,
    string[] Sections);

public static class LessonPricing
{
    public static bool IsFree(decimal? price) => price is null or <= 0;

    public static string Format(decimal? price) =>
        IsFree(price) ? "免费" : $"{price:0.##}元";
}

public record LessonCategory(string Name, string Icon, string Description);

public static class RoadmapTracks
{
    public static readonly LearningTrack[] All = [LearningTrack.GdScript, LearningTrack.CSharp, LearningTrack.Chronos];

    public static string GetLabel(LearningTrack track) => track switch
    {
        LearningTrack.GdScript => "GDScript 路线",
        LearningTrack.CSharp => "C# 路线",
        LearningTrack.Chronos => "Chronos 框架",
        _ => ""
    };

    public static string GetDescription(LearningTrack track) => track switch
    {
        LearningTrack.GdScript => "轻量易学，Godot 原生脚本",
        LearningTrack.CSharp => ".NET 生态，适合大型项目",
        LearningTrack.Chronos => "结构化游戏框架，快速搭建项目骨架",
        _ => ""
    };

    public static string GetIcon(LearningTrack track) => track switch
    {
        LearningTrack.GdScript => "🐍",
        LearningTrack.CSharp => "⚡",
        LearningTrack.Chronos => "⏳",
        _ => "📘"
    };

    public static string GetShortName(LearningTrack track) => track switch
    {
        LearningTrack.GdScript => "GDScript",
        LearningTrack.CSharp => "C#",
        LearningTrack.Chronos => "Chronos",
        _ => ""
    };

    public static int GetColumnIndex(LearningTrack track) => track switch
    {
        LearningTrack.GdScript => 1,
        LearningTrack.CSharp => 2,
        LearningTrack.Chronos => 3,
        _ => 1
    };
}

public static class RoadmapModules
{
    public static readonly string[] All = ["单机模块", "联机模块"];

    public static string GetDescription(string module) => module switch
    {
        "单机模块" => "搭建单机游戏的基础框架与核心流程",
        "联机模块" => "掌握网络同步、RPC 与多人联机开发",
        _ => ""
    };

    public static string GetIcon(string module) => module switch
    {
        "单机模块" => "🎮",
        "联机模块" => "🌐",
        _ => "📦"
    };
}

public static class RoadmapDimensions
{
    public static readonly string[] All = ["2D模块", "3D模块"];

    public static string GetDescription(string dimension) => dimension switch
    {
        "2D模块" => "精灵、瓦片地图与 2D 物理玩法开发",
        "3D模块" => "三维场景、模型、摄像机与 3D 物理",
        _ => ""
    };

    public static string GetIcon(string dimension) => dimension switch
    {
        "2D模块" => "🖼️",
        "3D模块" => "🧊",
        _ => "📐"
    };
}

public static class RoadmapStages
{
    public static readonly string[] All = ["炼气", "筑基", "结丹"];

    public static string GetDescription(string stage) => stage switch
    {
        "炼气" => "掌握脚本语法与引擎基本用法",
        "筑基" => "完成可运行的玩法 Demo 与系统搭建",
        "结丹" => "进阶 UI、架构与项目实战",
        _ => ""
    };
}
