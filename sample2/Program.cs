// File: Program.cs
// 概要: 簡単なデータ処理サンプル。
//       1. テキストファイルから行を読み込む
//       2. 空行を除去し、文字列を大文字に変換
//       3. アルファベット順にソート
//       4. 結果を新しいファイルに出力する

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataProcessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 入力ファイルと出力ファイルのパスを設定
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            Console.WriteLine("=== データ処理開始 ===");

            try
            {
                // 1. ファイル読み込み
                Console.WriteLine("[Step1] 入力ファイルを読み込みます...");
                List<string> lines = File.ReadAllLines(inputPath).ToList();

                // 2. データ加工（空行除去 & 大文字変換）
                Console.WriteLine("[Step2] 空行を除去し、大文字に変換します...");
                List<string> processed = lines
                    .Where(line => !string.IsNullOrWhiteSpace(line)) // 空行を除去
                    .Select(line => line.ToUpper()) // 大文字に変換
                    .ToList();

                // 3. ソート処理
                Console.WriteLine("[Step3] アルファベット順にソートします...");
                processed.Sort();

                // 4. 出力ファイルに書き込み
                Console.WriteLine("[Step4] 処理結果をファイルに保存します...");
                File.WriteAllLines(outputPath, processed);

                Console.WriteLine("=== データ処理が完了しました ===");
                Console.WriteLine($"出力ファイル: {outputPath}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("エラー: 入力ファイルが見つかりません。");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"エラーが発生しました: {ex.Message}");
            }
        }
    }
}
