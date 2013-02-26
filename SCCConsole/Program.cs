﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgClass;
using AlgClass.Graphs;

namespace SCCConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Count() == 1)
            {
                string filePath = args[0];
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                var edgesEnumerable = File.ReadLines(filePath);
                var edges = edgesEnumerable.Select(edge => edge.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                                   .Select(edgePair => new Tuple<uint,uint>(uint.Parse(edgePair[1]), (uint.Parse(edgePair[0]))))
                                   .ToArray();

                uint verticesCount = Math.Max(edges.Max(e => e.Item1), edges.Max(e => e.Item2));
                var vertices = Enumerable.Range(1, (int)verticesCount).Select(nodeId => new ExtendedVertex((uint)nodeId)).ToArray();

                edges.ForEach(edge =>
                              {
                                  vertices[edge.Item1 - 1].AdjacentVertices.Add(edge.Item2);
                                  vertices[edge.Item2 - 1].ReversedAdjacentVertices.Add(edge.Item1);
                              });
                      
                stopWatch.Stop();
                var initTime = stopWatch.ElapsedMilliseconds;
                Console.WriteLine("read and init time={0}", initTime);
                stopWatch.Restart();
                var alg = new KosarajuAlgorithm(vertices);
                var result = alg.CountStronglyConnectedComponentes();
                stopWatch.Stop();
                Console.WriteLine("running time = {0}, result={1}", stopWatch.ElapsedMilliseconds, string.Join(",", result.Take(10)));
                Console.WriteLine("press any key");
                Console.ReadLine();
            }
        }
    }
}