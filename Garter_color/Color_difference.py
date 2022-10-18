import cv2
import numpy as np

def locate_rectangle():
    left_edge = 250
    top_edge = 250
    width = 120
    interval = width + 100
    height = 300

    rectangles = []
    for window in range(15):
        x_min = left_edge + interval*window
        y_min = top_edge
        x_max = x_min+width
        y_max = y_min+height
        rectangles.append([x_min, y_min, x_max, y_max])
    return rectangles

def label_rectangle(img, rectangles):
    for windows in range(15):
        x_min = rectangles[windows][0]
        y_min = rectangles[windows][1]
        x_max = rectangles[windows][2]
        y_max = rectangles[windows][3]
        cv2.rectangle(img, (x_min, y_min), (x_max, y_max), (0, 0, 255), thickness=3)

    cv2.namedWindow('sample',0)
    cv2.resizeWindow('sample',800,200)
    cv2.imshow('sample', img)

def lab_value(img_lab, rectangles):
    for windows in range(15):
        x_min = rectangles[windows][0]
        y_min = rectangles[windows][1]
        x_max = rectangles[windows][2]
        y_max = rectangles[windows][3]
        L = np.mean(img_lab[y_min:y_max, x_min:x_max, 0])
        a = np.mean(img_lab[y_min:y_max, x_min:x_max, 1])
        b = np.mean(img_lab[y_min:y_max, x_min:x_max, 2])
        print("(", windows+1, ") L = ", round(L,2), ", a = ", round(a,2), ", b = ",round(b,2))

img_path = "./garter_sample.png"
img = cv2.imread(img_path)

rectangles = locate_rectangle()
label_rectangle(img, rectangles)
img_lab = cv2.cvtColor(img, cv2.COLOR_BGR2LAB)
lab_value(img_lab, rectangles)
cv2.waitKey(0)