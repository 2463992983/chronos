using Godot_Learning_WebSite.Models;

namespace Godot_Learning_WebSite.Services;

public class LessonService
{
    private readonly List<Lesson> _lessons =
    [
        // ── GDScript · 单机 · 2D ──
        new("install", "安装 Godot", "下载并配置 Godot 4 开发环境",
            LearningTrack.GdScript, "单机模块", "2D模块", "炼气", 1,
            "Godot 4.x", "炼气 · 环境搭建", "gdscript-solo",
            "完结", "2024/1/1 -- 2024/3/31", null,
        ["## 下载 Godot", "访问 [Godot 官网](https://godotengine.org/download) 下载 **Godot 4.x** 标准版。"]),
        new("nodes-scenes", "节点与场景", "理解 Godot 的核心架构：一切皆节点",
            LearningTrack.GdScript, "单机模块", "2D模块", "炼气", 2,
            "Godot 核心", "炼气 · 节点树", "gdscript-solo",
            "完结", "2024/2/1 -- 2024/4/30", null,
        ["## 节点（Node）", "例如 `Sprite2D`、`CollisionShape2D`、`Camera2D` 等。"]),
        new("gdscript-basics", "GDScript 基础", "学习 Godot 原生脚本语言的核心语法",
            LearningTrack.GdScript, "单机模块", "2D模块", "炼气", 3,
            "GDScript", "炼气 · 语法入门", "gdscript-qi",
            "完结", "2024/3/1 -- 2024/5/31", 19m,
        ["## 第一个脚本", "```gdscript\nextends Node2D\n\nfunc _ready():\n    print(\"Hello, Godot!\")\n```"]),
        new("2d-movement", "2D 角色移动", "用 CharacterBody2D 实现平台跳跃移动",
            LearningTrack.GdScript, "单机模块", "2D模块", "筑基", 4,
            "2D 实战", "筑基 · 角色控制", "gdscript-foundation",
            "完结", "2024/4/1 -- 2024/6/30", 39m,
        ["## 移动脚本", "使用 `move_and_slide()` 处理碰撞与移动。"]),
        new("ui-system", "UI 系统入门", "使用 Control 节点构建游戏界面",
            LearningTrack.GdScript, "单机模块", "2D模块", "结丹", 5,
            "UI 系统", "结丹 · 界面设计", "gdscript-golden",
            "完结", "2024/5/1 -- 2024/8/31", 59m,
        ["## Control 节点", "`Label`、`Button`、`ProgressBar`、`Panel` 等。"]),

        // ── GDScript · 单机 · 3D ──
        new("gdscript-3d-scene", "3D 场景入门", "创建第一个 3D 场景与摄像机",
            LearningTrack.GdScript, "单机模块", "3D模块", "炼气", 1,
            "3D 场景", "炼气 · 三维入门", "gdscript-3d-qi",
            "更新中", "2024/4/1 -- 2024/6/30", null,
        ["## 3D 节点", "`Node3D`、`MeshInstance3D`、`Camera3D`、`DirectionalLight3D`。"]),
        new("gdscript-3d-move", "3D 角色移动", "用 CharacterBody3D 实现第三人称移动",
            LearningTrack.GdScript, "单机模块", "3D模块", "筑基", 2,
            "3D 实战", "筑基 · 角色控制", "gdscript-3d-foundation",
            "更新中", "2024/5/1 -- 2024/7/31", 39m,
        ["## CharacterBody3D", "使用 `move_and_slide()` 在 3D 空间中移动。"]),
        new("gdscript-3d-light", "3D 光照与材质", "掌握 PBR 材质与光照设置",
            LearningTrack.GdScript, "单机模块", "3D模块", "结丹", 3,
            "3D 渲染", "结丹 · 画面表现", "gdscript-3d-golden",
            "更新中", "2024/6/1 -- 2024/9/30", 59m,
        ["## 标准材质", "调整 Albedo、Metallic、Roughness 等属性。"]),

        // ── GDScript · 联机 · 2D ──
        new("gdscript-net-basics", "网络基础入门", "了解 Godot 多人游戏的核心概念",
            LearningTrack.GdScript, "联机模块", "2D模块", "炼气", 1,
            "网络入门", "炼气 · 联机概念", "gdscript-online-qi",
            "更新中", "2024/6/1 -- 2024/8/31", null,
        ["## MultiplayerAPI", "```gdscript\nmultiplayer.peer_connected.connect(_on_peer_connected)\n```"]),
        new("gdscript-rpc", "RPC 与状态同步", "用 RPC 实现玩家间数据同步",
            LearningTrack.GdScript, "联机模块", "2D模块", "筑基", 2,
            "RPC 同步", "筑基 · 状态同步", "gdscript-online-foundation",
            "更新中", "2024/7/1 -- 2024/9/30", 49m,
        ["## RPC 调用", "```gdscript\n@rpc(\"any_peer\", \"call_local\")\nfunc sync_position(pos: Vector2):\n    global_position = pos\n```"]),
        new("gdscript-lobby", "联机房间与匹配", "搭建大厅、房间与玩家匹配系统",
            LearningTrack.GdScript, "联机模块", "2D模块", "结丹", 3,
            "联机大厅", "结丹 · 房间系统", "gdscript-online-golden",
            "更新中", "2024/8/1 -- 2024/11/30", 79m,
        ["## 房间流程", "创建/加入房间，使用 `MultiplayerSpawner` 同步场景。"]),

        // ── GDScript · 联机 · 3D ──
        new("gdscript-3d-net", "3D 联机基础", "在 3D 场景中同步玩家位置",
            LearningTrack.GdScript, "联机模块", "3D模块", "炼气", 1,
            "3D 联机", "炼气 · 网络同步", "gdscript-3d-online-qi",
            "更新中", "2024/7/1 -- 2024/9/30", 29m,
        ["## 3D 位置同步", "同步 `Vector3` 位置与旋转。"]),
        new("gdscript-3d-rpc", "3D RPC 实战", "多人 3D 场景中的 RPC 应用",
            LearningTrack.GdScript, "联机模块", "3D模块", "筑基", 2,
            "3D RPC", "筑基 · 多人同步", "gdscript-3d-online-foundation",
            "更新中", "2024/8/1 -- 2024/10/31", 49m,
        ["## 权威服务器", "服务器验证 3D 移动与交互。"]),

        // ── C# · 单机 · 2D ──
        new("csharp-env", "C# 开发环境", "配置 Godot .NET 版与 .NET SDK",
            LearningTrack.CSharp, "单机模块", "2D模块", "炼气", 1,
            "Godot .NET", "炼气 · 环境搭建", "csharp-solo",
            "完结", "2024/1/1 -- 2024/3/31", null,
        ["## 环境要求", "Godot **.NET 版本** + **.NET SDK 8.0**。"]),
        new("csharp-scenes", "C# 节点与场景", "在 C# 中操作节点树与场景",
            LearningTrack.CSharp, "单机模块", "2D模块", "炼气", 2,
            "场景架构", "炼气 · 节点树", "csharp-solo",
            "完结", "2024/2/1 -- 2024/4/30", null,
        ["## C# 节点脚本", "```csharp\npublic partial class Player : Node2D { }\n```"]),
        new("csharp-godot", "C# 语法基础", "在 Godot 中使用 C# 开发的核心语法",
            LearningTrack.CSharp, "单机模块", "2D模块", "炼气", 3,
            "C# 入门", "炼气 · 语法基础", "csharp-qi",
            "完结", "2024/3/1 -- 2024/5/31", 19m,
        ["## 第一个 C# 脚本", "```csharp\npublic override void _Ready() => GD.Print(\"Hello!\");\n```"]),
        new("csharp-movement", "C# 2D 移动", "用 C# 实现角色移动与输入",
            LearningTrack.CSharp, "单机模块", "2D模块", "筑基", 4,
            "2D 实战", "筑基 · 角色控制", "csharp-foundation",
            "更新中", "2024/4/1 -- 2024/7/31", 39m,
        ["## C# 移动", "使用 `MoveAndSlide()` 处理 2D 物理移动。"]),
        new("csharp-ui", "C# UI 开发", "用 C# 构建游戏界面与交互",
            LearningTrack.CSharp, "单机模块", "2D模块", "结丹", 5,
            "UI 进阶", "结丹 · 界面设计", "csharp-golden",
            "更新中", "2024/5/1 -- 2024/9/30", 59m,
        ["## 信号连接", "```csharp\nbutton.Pressed += OnButtonPressed;\n```"]),

        // ── C# · 单机 · 3D ──
        new("csharp-3d-scene", "C# 3D 场景", "用 C# 搭建 3D 场景与摄像机",
            LearningTrack.CSharp, "单机模块", "3D模块", "炼气", 1,
            "3D 场景", "炼气 · 三维入门", "csharp-3d-qi",
            "更新中", "2024/4/1 -- 2024/6/30", null,
        ["## Node3D", "```csharp\npublic partial class Player : CharacterBody3D { }\n```"]),
        new("csharp-3d-move", "C# 3D 移动", "第三人称 3D 角色控制",
            LearningTrack.CSharp, "单机模块", "3D模块", "筑基", 2,
            "3D 实战", "筑基 · 角色控制", "csharp-3d-foundation",
            "更新中", "2024/5/1 -- 2024/7/31", 39m,
        ["## 3D 物理", "在 `_PhysicsProcess` 中处理 3D 移动。"]),

        // ── C# · 联机 · 2D ──
        new("csharp-net-basics", "C# 网络基础", "在 C# 中使用 Godot 多人 API",
            LearningTrack.CSharp, "联机模块", "2D模块", "炼气", 1,
            "网络入门", "炼气 · 联机概念", "csharp-online-qi",
            "更新中", "2024/6/1 -- 2024/8/31", null,
        ["## MultiplayerApi", "```csharp\nMultiplayer.PeerConnected += OnPeerConnected;\n```"]),
        new("csharp-rpc", "C# RPC 同步", "用 C# 实现 RPC 与网络变量",
            LearningTrack.CSharp, "联机模块", "2D模块", "筑基", 2,
            "RPC 同步", "筑基 · 状态同步", "csharp-online-foundation",
            "更新中", "2024/7/1 -- 2024/9/30", 49m,
        ["## Rpc 属性", "```csharp\n[Rpc] public void SyncPosition(Vector2 pos) => Position = pos;\n```"]),
        new("csharp-lobby", "C# 联机大厅", "用 C# 搭建多人房间与匹配",
            LearningTrack.CSharp, "联机模块", "2D模块", "结丹", 3,
            "联机大厅", "结丹 · 房间系统", "csharp-online-golden",
            "更新中", "2024/8/1 -- 2024/11/30", 79m,
        ["## 房间管理", "创建房间、加入房间、玩家列表与开始游戏。"]),

        // ── C# · 联机 · 3D ──
        new("csharp-3d-net", "C# 3D 联机", "3D 多人场景网络同步",
            LearningTrack.CSharp, "联机模块", "3D模块", "炼气", 1,
            "3D 联机", "炼气 · 网络同步", "csharp-3d-online-qi",
            "更新中", "2024/7/1 -- 2024/9/30", 29m,
        ["## 3D 同步", "同步玩家 `Transform3D` 与动画状态。"]),

        // ── Chronos · 单机 · 2D ──
        new("chronos-intro", "Chronos 框架入门", "了解 Chronos 项目结构与核心概念",
            LearningTrack.Chronos, "单机模块", "2D模块", "炼气", 1,
            "Chronos", "炼气 · 框架概览", "chronos-qi",
            "更新中", "2024/5/1 -- 2024/7/31", null,
        ["## 什么是 Chronos", "Chronos 是面向 Godot 的结构化游戏框架，提供场景流转、模块划分与约定式目录。"]),
        new("chronos-modules", "模块与生命周期", "掌握 Chronos 模块注册与生命周期钩子",
            LearningTrack.Chronos, "单机模块", "2D模块", "炼气", 2,
            "模块系统", "炼气 · 生命周期", "chronos-qi",
            "更新中", "2024/6/1 -- 2024/8/31", null,
        ["## 模块划分", "按玩法、UI、数据层拆分模块，降低耦合。"]),
        new("chronos-2d-gameplay", "2D 玩法模块", "用 Chronos 搭建 2D 玩法循环",
            LearningTrack.Chronos, "单机模块", "2D模块", "筑基", 3,
            "2D 玩法", "筑基 · 玩法循环", "chronos-foundation",
            "更新中", "2024/7/1 -- 2024/9/30", 49m,
        ["## GameLoop", "统一 Tick、输入与状态机驱动 2D 玩法。"]),
        new("chronos-ui-flow", "UI 流程与导航", "Chronos UI 栈与界面流转",
            LearningTrack.Chronos, "单机模块", "2D模块", "结丹", 4,
            "UI 流程", "结丹 · 界面导航", "chronos-golden",
            "更新中", "2024/8/1 -- 2024/10/31", 89m,
        ["## UI 栈", "Push/Pop 界面，管理返回与遮罩层。"]),

        // ── Chronos · 单机 · 3D ──
        new("chronos-3d-scene", "3D 场景模块", "Chronos 下的 3D 场景组织",
            LearningTrack.Chronos, "单机模块", "3D模块", "炼气", 1,
            "3D 场景", "炼气 · 场景模块", "chronos-3d-qi",
            "更新中", "2024/6/1 -- 2024/8/31", null,
        ["## 3D 场景树", "用 Chronos 模块加载主场景、子关卡与过渡。"]),
        new("chronos-3d-camera", "3D 相机与角色", "第三人称相机与角色模块",
            LearningTrack.Chronos, "单机模块", "3D模块", "筑基", 2,
            "3D 控制", "筑基 · 相机角色", "chronos-3d-foundation",
            "更新中", "2024/7/1 -- 2024/9/30", 49m,
        ["## 相机模块", "可插拔的跟随相机与输入映射。"]),

        // ── Chronos · 联机 · 2D ──
        new("chronos-net", "Chronos 联机架构", "框架内的网络层与房间抽象",
            LearningTrack.Chronos, "联机模块", "2D模块", "炼气", 1,
            "联机架构", "炼气 · 网络层", "chronos-online-qi",
            "更新中", "2024/8/1 -- 2024/10/31", 29m,
        ["## 网络模块", "统一 Session、Peer 与消息分发接口。"]),
        new("chronos-sync", "状态同步模块", "Chronos 下的实体同步与预测",
            LearningTrack.Chronos, "联机模块", "2D模块", "筑基", 2,
            "状态同步", "筑基 · 同步策略", "chronos-online-foundation",
            "更新中", "2024/9/1 -- 2024/11/30", 59m,
        ["## 同步组件", "为实体挂载可复制的状态组件。"]),
        new("chronos-match", "匹配与大厅", "房间匹配与服务发现",
            LearningTrack.Chronos, "联机模块", "2D模块", "结丹", 3,
            "匹配大厅", "结丹 · 房间匹配", "chronos-online-golden",
            "更新中", "2024/10/1 -- 2024/12/31", 99m,
        ["## 大厅流程", "列表房间、创建、加入与断线重连。"]),

        // ── Chronos · 联机 · 3D ──
        new("chronos-3d-net", "3D 联机模块", "Chronos 3D 多人场景同步",
            LearningTrack.Chronos, "联机模块", "3D模块", "炼气", 1,
            "3D 联机", "炼气 · 多人场景", "chronos-3d-online-qi",
            "更新中", "2024/9/1 -- 2024/11/30", 39m,
        ["## 3D 实体同步", "Transform 与动画状态的模块级同步。"])
    ];

    public IReadOnlyList<Lesson> GetAll() => _lessons.OrderBy(l => l.Order).ToList();

    public Lesson? GetBySlug(string slug) => _lessons.FirstOrDefault(l => l.Slug == slug);

    public IEnumerable<Lesson> GetByPath(LearningTrack track, string module, string dimension) =>
        _lessons.Where(l => l.Track == track && l.Module == module && l.Dimension == dimension)
            .OrderBy(l => l.Order);

    public IEnumerable<Lesson> GetByPathAndStage(LearningTrack track, string module, string dimension, string stage) =>
        _lessons.Where(l => l.Track == track && l.Module == module && l.Dimension == dimension && l.Stage == stage)
            .OrderBy(l => l.Order);

    public IReadOnlyList<LessonCategory> GetCategories() =>
    [
        new("单机模块", "🎮", RoadmapModules.GetDescription("单机模块")),
        new("联机模块", "🌐", RoadmapModules.GetDescription("联机模块")),
        new("2D模块", "🖼️", RoadmapDimensions.GetDescription("2D模块")),
        new("3D模块", "🧊", RoadmapDimensions.GetDescription("3D模块")),
        new("炼气", "✨", RoadmapStages.GetDescription("炼气")),
        new("筑基", "🏗️", RoadmapStages.GetDescription("筑基")),
        new("结丹", "💎", RoadmapStages.GetDescription("结丹"))
    ];
}
