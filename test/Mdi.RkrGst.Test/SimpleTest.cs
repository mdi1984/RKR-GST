﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mdi.RkrGst.Collections;
using Mdi.RkrGst.Model;
using Xunit;

namespace Mdi.RkrGst.Test
{
  public class SimpleTest
  {
    [Fact]
    public void RingBufferTest()
    {
            var bufferA = new RingBuffer<int>(10)
            {
                8372,
                8508,
                8218,
                8508,
                8218,
                8508,
                8205,
                8343,
                8374
            };
            Assert.True(bufferA.Count != bufferA.Capacity);

      bufferA.Add(8508);

      Assert.True(bufferA.Count == bufferA.Capacity);

            var bufferB = new RingBuffer<int>(10)
            {
                42,
                8372,
                8508,
                8218,
                8508,
                8218,
                8508,
                8205,
                8343,
                8374,
                8508
            };
            Assert.True(bufferA.GetHashCode() == bufferB.GetHashCode());
    }

    [Fact]
    public void SimpleComparatorTest()
    {
      // UserViewmodel.cs
      var submissionA = new SimpleSubmission<int>(new int[] { 8373, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8372, 8508, 8218, 8508, 8218, 8508, 8205, 8343, 8374, 8508, 8211, 8508, 8205, 8344, 8304, 8508, 8212, 8343, 8304, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8206, 8206, 8344, 8508, 8508, 8212, 8343, 8508, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8206, 8206, 8344, 8508, 8215, 8508, 8217, 8508, 8212, 8344, 8508, 8508, 8212, 8343, 8508, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8206, 8344, 8316, 8508, 8212, 8343, 8316, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8508, 8200, 8200, 8201, 8269, 8508, 8201, 8212, 8508, 8218, 8508, 8204, 8508, 8212, 8206, 8206, 8344, 8304, 8508, 8200, 8319, 8508, 8201, 8205, 8508, 8508, 8204, 8508, 8364, 8508, 8212, 8341, 8508, 8218, 8508, 8218, 8508, 8200, 8201, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8260, 8508, 8218, 8508, 8218, 8508, 8200, 8201, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8260, 8508, 8218, 8508, 8218, 8508, 8200, 8201, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8212, 8206, 8344, 8508, 8508, 8212, 8343, 8508, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8206, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8344, 8435, 8318, 8508, 8200, 8201, 8205, 8508, 8204, 8322, 8212, 8436, 8508, 8200, 8201, 8212, 8508, 8204, 8508, 8218, 8508, 8212, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8344, 8435, 8318, 8508, 8200, 8201, 8205, 8334, 8205, 8508, 8204, 8323, 8212, 8436, 8508, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8212, 8508, 8204, 8322, 8212, 8436, 8508, 8200, 8201, 8212, 8508, 8204, 8508, 8218, 8508, 8212, 8508, 8204, 8324, 8212, 8206, 8335, 8200, 8508, 8508, 8201, 8205, 8508, 8204, 8324, 8212, 8508, 8218, 8508, 8218, 8508, 8215, 8316, 8217, 8200, 8508, 8218, 8508, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8344, 8318, 8508, 8200, 8201, 8205, 8508, 8204, 8354, 8508, 8200, 8201, 8212, 8508, 8204, 8508, 8218, 8508, 8212, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8344, 8318, 8508, 8200, 8508, 8508, 8201, 8205, 8508, 8204, 8508, 8212, 8508, 8204, 8508, 8218, 8508, 8212, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8344, 8318, 8508, 8200, 8508, 8508, 8201, 8205, 8508, 8218, 8508, 8218, 8508, 8215, 8508, 8215, 8508, 8216, 8316, 8217, 8217, 8200, 8354, 8508, 8215, 8508, 8216, 8316, 8217, 8200, 8435, 8200, 8201, 8269, 8205, 8334, 8205, 8508, 8204, 8323, 8212, 8436, 8508, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8212, 8436, 8508, 8200, 8201, 8212, 8508, 8204, 8324, 8212, 8206, 8335, 8200, 8508, 8508, 8201, 8205, 8508, 8204, 8324, 8212, 8508, 8218, 8508, 8218, 8508, 8215, 8316, 8217, 8200, 8508, 8218, 8508, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8216, 8508, 8218, 8508, 8200, 8511, 8216, 8508, 8218, 8508, 8201, 8201, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8344, 8318, 8508, 8200, 8508, 8508, 8201, 8205, 8508, 8218, 8508, 8218, 8508, 8215, 8508, 8215, 8508, 8216, 8316, 8217, 8217, 8200, 8354, 8508, 8215, 8508, 8216, 8316, 8217, 8200, 8435, 8200, 8201, 8269, 8205, 8334, 8205, 8508, 8204, 8323, 8212, 8436, 8508, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8212, 8436, 8508, 8200, 8201, 8212, 8508, 8204, 8324, 8212, 8206, 8335, 8200, 8508, 8508, 8201, 8205, 8508, 8204, 8324, 8212, 8508, 8218, 8508, 8218, 8508, 8215, 8316, 8217, 8200, 8508, 8218, 8508, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8216, 8508, 8218, 8508, 8200, 8511, 8216, 8508, 8218, 8508, 8201, 8201, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8508, 8508, 8212, 8343, 8508, 8200, 8201, 8205, 8508, 8204, 8324, 8212, 8508, 8204, 8508, 8218, 8508, 8212, 8508, 8204, 8354, 8508, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8215, 8508, 8217, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8215, 8508, 8217, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8215, 8508, 8217, 8200, 8508, 8201, 8212, 8508, 8204, 8508, 8218, 8508, 8200, 8201, 8212, 8508, 8204, 8354, 8508, 8215, 8508, 8217, 8200, 8201, 8212, 8508, 8204, 8508, 8218, 8508, 8200, 8508, 8201, 8212, 8508, 8200, 8201, 8212, 8206, 8344, 8435, 8508, 8508, 8200, 8201, 8205, 8334, 8205, 8508, 8204, 8323, 8212, 8508, 8508, 8204, 8436, 8508, 8218, 8508, 8200, 8201, 8212, 8508, 8218, 8508, 8200, 8201, 8212, 8329, 8200, 8508, 8508, 8362, 8508, 8201, 8205, 8508, 8218, 8508, 8200, 8354, 8508, 8200, 8508, 8201, 8201, 8212, 8206, 8508, 8200, 8200, 8201, 8269, 8508, 8201, 8212, 8508, 8204, 8324, 8212, 8206, 8335, 8200, 8508, 8508, 8201, 8205, 8508, 8204, 8324, 8212, 8508, 8218, 8508, 8218, 8508, 8215, 8316, 8217, 8200, 8508, 8218, 8508, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8206, 8206, 8496 });
      // PresentationViewModel.cs
      var submissionB = new SimpleSubmission<int>(new int[] { 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8373, 8508, 8218, 8508, 8218, 8508, 8212, 8372, 8508, 8218, 8508, 8218, 8508, 8205, 8343, 8374, 8508, 8211, 8508, 8205, 8344, 8508, 8508, 8212, 8344, 8508, 8508, 8212, 8344, 8508, 8508, 8212, 8343, 8508, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8206, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8205, 8309, 8508, 8204, 8508, 8218, 8508, 8217, 8509, 8219, 8509, 8211, 8508, 8218, 8508, 8212, 8325, 8200, 8508, 8217, 8509, 8201, 8341, 8508, 8218, 8508, 8200, 8201, 8218, 8508, 8200, 8509, 8216, 8508, 8201, 8212, 8326, 8341, 8322, 8212, 8206, 8206, 8344, 8508, 8508, 8212, 8343, 8508, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8206, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8212, 8418, 8212, 8206, 8343, 8508, 8215, 8508, 8217, 8508, 8205, 8417, 8205, 8309, 8508, 8204, 8508, 8218, 8508, 8217, 8509, 8219, 8509, 8211, 8508, 8218, 8508, 8212, 8325, 8200, 8508, 8217, 8509, 8201, 8341, 8508, 8218, 8508, 8200, 8201, 8218, 8508, 8200, 8509, 8216, 8508, 8201, 8212, 8326, 8341, 8322, 8212, 8206, 8206, 8344, 8304, 8508, 8212, 8343, 8304, 8508, 8205, 8417, 8205, 8341, 8508, 8212, 8206, 8418, 8205, 8508, 8200, 8200, 8201, 8269, 8508, 8216, 8360, 8508, 8216, 8508, 8201, 8212, 8508, 8200, 8200, 8201, 8269, 8508, 8201, 8212, 8206, 8206, 8343, 8304, 8508, 8205, 8417, 8205, 8341, 8194, 8508, 8212, 8206, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8344, 8418, 8212, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8344, 8418, 8212, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8344, 8418, 8212, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8344, 8418, 8212, 8206, 8343, 8508, 8508, 8205, 8417, 8212, 8344, 8418, 8212, 8206, 8344, 8318, 8508, 8200, 8201, 8205, 8337, 8200, 8508, 8201, 8205, 8325, 8200, 8508, 8218, 8508, 8217, 8509, 8201, 8205, 8508, 8204, 8508, 8218, 8508, 8200, 8201, 8212, 8508, 8218, 8508, 8204, 8323, 8212, 8508, 8218, 8508, 8200, 8508, 8218, 8508, 8200, 8201, 8201, 8212, 8508, 8218, 8508, 8200, 8508, 8201, 8212, 8508, 8200, 8200, 8201, 8269, 8508, 8201, 8212, 8508, 8204, 8508, 8218, 8508, 8268, 8508, 8218, 8508, 8218, 8508, 8219, 8323, 8211, 8324, 8212, 8508, 8218, 8508, 8218, 8508, 8215, 8508, 8217, 8200, 8508, 8218, 8508, 8200, 8201, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8206, 8344, 8318, 8508, 8200, 8201, 8205, 8325, 8200, 8508, 8267, 8322, 8201, 8205, 8508, 8218, 8508, 8218, 8508, 8215, 8508, 8217, 8200, 8508, 8218, 8508, 8200, 8201, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8344, 8318, 8508, 8200, 8201, 8205, 8325, 8200, 8508, 8267, 8322, 8201, 8205, 8508, 8218, 8508, 8218, 8508, 8215, 8508, 8217, 8200, 8508, 8218, 8508, 8200, 8201, 8216, 8508, 8218, 8508, 8201, 8212, 8206, 8206, 8344, 8318, 8508, 8200, 8508, 8508, 8201, 8205, 8309, 8508, 8212, 8337, 8200, 8508, 8201, 8205, 8508, 8204, 8508, 8218, 8508, 8212, 8206, 8325, 8200, 8508, 8267, 8509, 8201, 8205, 8508, 8200, 8201, 8212, 8206, 8206, 8344, 8319, 8508, 8212, 8343, 8508, 8200, 8201, 8205, 8508, 8204, 8508, 8218, 8508, 8200, 8201, 8212, 8508, 8204, 8354, 8508, 8215, 8508, 8217, 8200, 8201, 8212, 8508, 8204, 8354, 8508, 8215, 8508, 8217, 8200, 8201, 8212, 8508, 8204, 8354, 8508, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8200, 8508, 8201, 8212, 8508, 8204, 8354, 8508, 8200, 8508, 8201, 8212, 8508, 8218, 8508, 8218, 8508, 8215, 8508, 8217, 8200, 8370, 8216, 8508, 8218, 8508, 8216, 8508, 8201, 8212, 8508, 8204, 8354, 8319, 8200, 8201, 8212, 8508, 8204, 8354, 8508, 8200, 8509, 8201, 8212, 8508, 8218, 8508, 8280, 8508, 8212, 8508, 8218, 8508, 8200, 8201, 8212, 8206, 8344, 8435, 8318, 8508, 8200, 8319, 8508, 8216, 8508, 8508, 8201, 8205, 8436, 8508, 8200, 8201, 8212, 8206, 8343, 8435, 8508, 8508, 8200, 8201, 8205, 8508, 8204, 8322, 8212, 8436, 8508, 8200, 8201, 8212, 8206, 8344, 8435, 8508, 8508, 8200, 8201, 8205, 8508, 8508, 8204, 8436, 8508, 8218, 8508, 8200, 8508, 8201, 8212, 8337, 8200, 8508, 8201, 8205, 8508, 8218, 8508, 8200, 8201, 8212, 8329, 8200, 8508, 8508, 8362, 8508, 8201, 8205, 8508, 8218, 8508, 8200, 8354, 8508, 8200, 8508, 8201, 8201, 8212, 8206, 8508, 8200, 8200, 8201, 8269, 8508, 8201, 8212, 8206, 8508, 8508, 8204, 8436, 8508, 8218, 8508, 8200, 8508, 8201, 8212, 8508, 8218, 8508, 8200, 8201, 8212, 8329, 8200, 8508, 8508, 8362, 8508, 8201, 8205, 8508, 8218, 8508, 8200, 8508, 8201, 8212, 8206, 8508, 8200, 8200, 8201, 8269, 8508, 8201, 8212, 8206, 8206, 8206, 8496 });

      var comparator = new Comparator<int>(10, submissionA, submissionB);
      var result = comparator.Compare();
      Assert.Equal(12, result.Count);
    }

    [Fact]
    public void TextComparatorTest()
    {
      var submissionA = new SimpleSubmission<char>(new char[] { 'a', 'd', 'o', 'r', 'u', 'n', 'r', 'u', 'n', 'r', 'u', 'n', 'a', 'd', 'o', 'r', 'u', 'n', 'r', 'u', 'n' });
      var submissionB = new SimpleSubmission<char>(new char[] { 'r', 'u', 'n', 'a', 'd', 'o', 'r', 'u', 'n' });

      var comparator = new Comparator<char>(8, submissionA, submissionB);
      var result = comparator.Compare();
      Assert.Equal(1, result.Count);
      Assert.Equal(9, result.First().TextPosition);
      Assert.Equal(0, result.First().PatternPosition);
    }
  }
}
