// Program.cs
// ===========================
// このファイルはエントリーポイント (Main) を持つクラス。
// TaskService と TaskItem を使って簡易的なタスク管理のデモを行う。
// - タスクを追加
// - 登録されたタスクを一覧表示
// - 疑似的に非同期保存処理を実行
// ===========================

using System;
using System.Threading.Tasks;

namespace CSharpSamples
{
    class Program
    {
        // エントリーポイント (async対応 Main)
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Simple Task Manager ===");

            // タスク管理用サービスのインスタンス作成
            var service = new TaskService();

            // サンプルのタスクを追加
            service.AddTask(new TaskItem("Learn C#", DateTime.Now.AddDays(1)));
            service.AddTask(new TaskItem("Push code to GitHub", DateTime.Now.AddDays(2)));

            // 登録されているタスク一覧を表示
            Console.WriteLine("\nAll tasks:");
            foreach (var task in service.GetAllTasks())
            {
                Console.WriteLine(task);
            }

            // 疑似的な非同期保存処理を実行
            Console.WriteLine("\nSimulating async save...");
            await service.SaveTasksAsync();

            Console.WriteLine("\nDone!");
        }
    }
}
