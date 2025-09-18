// TaskService.cs
// ===========================
// このファイルはタスク管理を行うサービスクラス。
// - タスクの追加
// - タスク一覧の取得（期限順）
// - 疑似的な非同期保存処理
// ===========================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpSamples
{
    // タスクを管理するサービスクラス
    public class TaskService
    {
        // 登録されたタスクを保持するリスト
        private readonly List<TaskItem> _tasks = new();

        // タスクを新しく追加する処理
        public void AddTask(TaskItem task)
        {
            _tasks.Add(task);
            Console.WriteLine($"[INFO] Task added: {task.Title}");
        }

        // 登録されている全タスクを期限順に返す
        public IEnumerable<TaskItem> GetAllTasks()
        {
            return _tasks.OrderBy(t => t.DueDate);
        }

        // 疑似的にタスクを非同期で保存する処理
        public async Task SaveTasksAsync()
        {
            await Task.Delay(500); // 0.5秒待機して保存処理っぽく見せる
            Console.WriteLine("[INFO] Tasks saved successfully (simulated).");
        }
    }
}
