/**
 * File: insertion_sort.c
 * Created Time: 2022-12-29
 * Author: Listening (https://github.com/L-Super)
 */

#include "../include/include.h"

/* 插入排序 */
void insertionSort(int nums[], int size) {
    // 外循环：base = nums[1], nums[2], ..., nums[n-1]
    for (int i = 1; i < size; i++) {
        int base = nums[i], j = i - 1;
        // 内循环：将 base 插入到左边的正确位置
        while (j >= 0 && nums[j] > base) {
            // 1. 将 nums[j] 向右移动一位
            nums[j + 1] = nums[j];
            j--;
        }
        // 2. 将 base 赋值到正确位置
        nums[j + 1] = base;
    }
}

/* Driver Code */
int main() {
    int nums[] = {4, 1, 3, 1, 5, 2};
    insertionSort(nums, 6);
    printf("插入排序完成后 nums = ");
    for (int i = 0; i < 6; i++) {
        printf("%d ", nums[i]);
    }
    printf("\n");

    return 0;
}
