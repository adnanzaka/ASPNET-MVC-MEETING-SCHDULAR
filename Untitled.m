net = alexnet;
I = imread('peppers.png');
I = imresize(I,sz(1:2));
label = classify(net,I)
figure
imshow(I)
title(label)
