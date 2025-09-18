// TaskItem.cs
// ===========================
// このファイルは「タスク1件」を表すモデルクラス。
// - タイトル、期限、完了状態を保持
// - 完了済みにするメソッド
// - ToString() のオーバーライドで表示フォーマットを定義
// ===========================

using System;

namespace CSharpSamples
{
    // 1件のタスクを表すモデルクラス
    public class TaskItem
    {
        // タスクのタイトル（例: "Learn C#"）
        public string Title { get; }

        // タスクの期限
        public DateTime DueDate { get; }

        // タスクが完了済みかどうか
        public bool IsCompleted { get; private set; }

        // コンストラクタ: タスク作成時にタイトルと期限を指定
        public TaskItem(string title, DateTime dueDate)
        {
            Title = title;
            DueDate = dueDate;
            IsCompleted = false; // 初期状態は未完了
        }

        // タスクを完了済みに変更する
        public void Complete() => IsCompleted = true;

        // タスクを文字列として表示する際のフォーマットを定義
        public override string ToString()
        {
            var status = IsCompleted ? "✔ Done" : "⏳ Pending";
            return $"{Title} (Due: {DueDate:d}) - {status}";
        }
    }
}
