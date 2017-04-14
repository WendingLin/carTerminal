import sys
import cv2
import numpy as np 



import kcftracker

if __name__ == '__main__':
        path1=sys.argv[1]
        ix=int(sys.argv[2])
        iy=int(sys.argv[3])
        w=int(sys.argv[4])
        h=int(sys.argv[5])
        path2=sys.argv[6]

        frame_b = cv2.imread(path1)
        dsize = (640, 360);  
        frame_b=cv2.resize(frame_b, dsize, interpolation=cv2.INTER_AREA);
        ix, iy, w, h =int(ix),int(iy),int(w),int(h)
        #print ix,iy,w,h
        frame_n = cv2.imread(path2) 
        frame_n=cv2.resize(frame_n, dsize, interpolation=cv2.INTER_AREA);

        tracker = kcftracker.KCFTracker(False, True, True)  # hog, fixed_window, multiscale
        #if you use hog feature, there will be a short pause after you draw a first boundingbox, that is due to the use of Numba.

        cv2.namedWindow('tracking')

        tracker.init([ix,iy,w,h], frame_b)
        cv2.rectangle(frame_b,(ix,iy), (ix+w,iy+h), (0,255,255), 1)
        cv2.imshow('tracking', frame_b)
        cv2.waitKey(0)
        
        #t0 = time()
        boundingbox = tracker.update(frame_n)
        #t1 = time()

        boundingbox = map(int, boundingbox)
        cv2.rectangle(frame_n,(boundingbox[0],boundingbox[1]), (boundingbox[0]+boundingbox[2],boundingbox[1]+boundingbox[3]), (0,255,255), 1)
        #print t1-t0
        cv2.imshow('tracking', frame_n)
        cv2.waitKey(0)

        cv2.destroyAllWindows()
        fi=open("data.txt", "w+")
        fi.write(str(boundingbox[0])+","+str(boundingbox[1])+","+str(boundingbox[2])+","+str(boundingbox[3]))
        fi.close()
        #return boundingbox[0],boundingbox[1],boundingbox[2],boundingbox[3]
