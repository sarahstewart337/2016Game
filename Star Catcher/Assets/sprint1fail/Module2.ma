//Maya ASCII 2017 scene
//Name: Module2.ma
//Last modified: Thu, Sep 22, 2016 05:36:58 AM
//Codeset: 1252
requires maya "2017";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201606150345-997974";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -n "Module2:pCube1";
	rename -uid "CE18345A-4575-6E53-71F6-0E8E1378ADE4";
	setAttr ".t" -type "double3" -12.917213785480293 40.677170269779637 -5.5991085387292339 ;
	setAttr ".s" -type "double3" 1.0776366876468189 1 1.1527755721484798 ;
createNode mesh -n "Module2:pCubeShape1" -p "Module2:pCube1";
	rename -uid "28E65CE4-4CA9-09BC-5132-A388075247C9";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.75 0.125 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 64 ".pt";
	setAttr ".pt[1]" -type "float3" 5.4883409 0 8.8817842e-016 ;
	setAttr ".pt[3]" -type "float3" 5.4883409 0 8.8817842e-016 ;
	setAttr ".pt[5]" -type "float3" 5.4883409 0 0 ;
	setAttr ".pt[7]" -type "float3" 5.4883409 0 0 ;
	setAttr ".pt[10]" -type "float3" 0 -0.11934687 0 ;
	setAttr ".pt[11]" -type "float3" 0 -0.11934687 0 ;
	setAttr ".pt[13]" -type "float3" 0 -3.9241688 -8.8817842e-016 ;
	setAttr ".pt[14]" -type "float3" 0 -3.9241688 -5.5511151e-016 ;
	setAttr ".pt[17]" -type "float3" 0 -2.5793903 -8.8817842e-016 ;
	setAttr ".pt[18]" -type "float3" 0 -2.5793903 -6.6613381e-016 ;
	setAttr ".pt[21]" -type "float3" 0.096064426 5.8446369 -8.8817842e-016 ;
	setAttr ".pt[22]" -type "float3" 0.096064426 5.8446369 -5.5511151e-016 ;
	setAttr ".pt[31]" -type "float3" 0 -0.0024558262 0 ;
	setAttr ".pt[32]" -type "float3" 0 0.079442255 0 ;
	setAttr ".pt[33]" -type "float3" 0 0.95558482 0 ;
	setAttr ".pt[34]" -type "float3" 5.4883409 0 8.8817842e-016 ;
	setAttr ".pt[35]" -type "float3" 5.4883409 0 0 ;
	setAttr ".pt[36]" -type "float3" 0 0.95558482 -1.110223e-016 ;
	setAttr ".pt[37]" -type "float3" 0 0.079442255 0 ;
	setAttr ".pt[38]" -type "float3" 0 -0.0024558262 0 ;
	setAttr ".pt[45]" -type "float3" 0 -0.71955317 0 ;
	setAttr ".pt[46]" -type "float3" 0 0.56856745 -1.110223e-016 ;
	setAttr ".pt[47]" -type "float3" 0 4.1862426 -3.8857806e-016 ;
	setAttr ".pt[48]" -type "float3" 5.4883409 0 0 ;
	setAttr ".pt[49]" -type "float3" 5.4883409 0 8.8817842e-016 ;
	setAttr ".pt[50]" -type "float3" 0 4.1862426 0 ;
	setAttr ".pt[51]" -type "float3" 0 0.56856745 0 ;
	setAttr ".pt[52]" -type "float3" 0 -0.71955317 0 ;
	setAttr ".pt[57]" -type "float3" 0 0.51569992 0 ;
	setAttr ".pt[58]" -type "float3" 0.11752679 3.5459416 0 ;
	setAttr ".pt[59]" -type "float3" 0.99710041 4.9130511 -1.7763568e-015 ;
	setAttr ".pt[60]" -type "float3" 0.99710041 4.9130511 -1.110223e-015 ;
	setAttr ".pt[61]" -type "float3" 0.11752679 3.5459416 -2.7755576e-016 ;
	setAttr ".pt[62]" -type "float3" 0 0.51569992 -5.5511151e-017 ;
	setAttr ".pt[64]" -type "float3" 0.051086172 0.44254377 0 ;
	setAttr ".pt[67]" -type "float3" 0.051086172 0.44254377 0 ;
	setAttr ".pt[68]" -type "float3" 0.61403739 4.8517179 0 ;
	setAttr ".pt[69]" -type "float3" 1.0434464 4.8799381 -1.7763568e-015 ;
	setAttr ".pt[70]" -type "float3" 1.0434464 4.8799381 -1.110223e-015 ;
	setAttr ".pt[71]" -type "float3" 0.61403739 4.8517179 -1.6653345e-016 ;
	setAttr ".pt[72]" -type "float3" 0.079406194 0.55056614 0 ;
	setAttr ".pt[75]" -type "float3" 0.079406194 0.55056614 0 ;
	setAttr ".pt[76]" -type "float3" 0.58105862 3.4940164 0 ;
	setAttr ".pt[77]" -type "float3" 1.0434464 6.0555143 0 ;
	setAttr ".pt[78]" -type "float3" 1.0434464 6.0555143 -1.110223e-016 ;
	setAttr ".pt[79]" -type "float3" 0.58105862 3.4940164 0 ;
	setAttr ".pt[83]" -type "float3" 0 -0.36518869 0 ;
	setAttr ".pt[84]" -type "float3" 0 -0.90852648 0 ;
	setAttr ".pt[85]" -type "float3" 0 -0.90852648 0 ;
	setAttr ".pt[86]" -type "float3" 0 -0.36518869 0 ;
	setAttr ".pt[88]" -type "float3" 0 0.35863709 0 ;
	setAttr ".pt[91]" -type "float3" 0 0.35863709 0 ;
	setAttr ".pt[92]" -type "float3" 0.01785236 1.2708894 0 ;
	setAttr ".pt[93]" -type "float3" 0.2746304 3.101105 0 ;
	setAttr ".pt[94]" -type "float3" 0.2746304 3.101105 0 ;
	setAttr ".pt[95]" -type "float3" 0.01785236 1.2708894 0 ;
	setAttr ".pt[96]" -type "float3" 0 0.38184893 0 ;
	setAttr ".pt[99]" -type "float3" 0 0.38184893 0 ;
	setAttr ".pt[100]" -type "float3" 0 1.2364649 0 ;
	setAttr ".pt[101]" -type "float3" 0 5.8227353 0 ;
	setAttr ".pt[102]" -type "float3" 0 5.8227353 0 ;
	setAttr ".pt[103]" -type "float3" 0 1.2364649 0 ;
	setAttr ".pt[109]" -type "float3" 0 4.1120648 0 ;
	setAttr ".pt[110]" -type "float3" 0 4.1120648 0 ;
	setAttr ".dr" 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode polySplit -n "Module2:polySplit16";
	rename -uid "963DCC3E-426C-FA6B-6A0D-DF9819CE8617";
	setAttr -s 9 ".e[0:8]"  0.333298 0.66670197 0.333298 0.333298 0.333298
		 0.66670197 0.333298 0.333298 0.333298;
	setAttr -s 9 ".d[0:8]"  -2147483443 -2147483428 -2147483437 -2147483438 -2147483439 -2147483424 
		-2147483441 -2147483442 -2147483443;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit15";
	rename -uid "5BC4CE0F-431D-CDF1-0CC4-ADA01E41AF96";
	setAttr -s 9 ".e[0:8]"  0.248284 0.75171602 0.75171602 0.75171602
		 0.248284 0.75171602 0.75171602 0.75171602 0.248284;
	setAttr -s 9 ".d[0:8]"  -2147483575 -2147483443 -2147483442 -2147483441 -2147483547 -2147483439 
		-2147483438 -2147483437 -2147483575;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit14";
	rename -uid "040A9CE6-45EE-2B96-6701-43B206909521";
	setAttr -s 9 ".e[0:8]"  0.56359899 0.43640101 0.43640101 0.43640101
		 0.56359899 0.43640101 0.43640101 0.43640101 0.56359899;
	setAttr -s 9 ".d[0:8]"  -2147483575 -2147483459 -2147483458 -2147483457 -2147483547 -2147483455 
		-2147483454 -2147483453 -2147483575;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit13";
	rename -uid "9BDE3638-4C42-EE2B-27EF-0283DDE5F5F5";
	setAttr -s 9 ".e[0:8]"  0.78282499 0.21717501 0.21717501 0.21717501
		 0.78282499 0.21717501 0.21717501 0.21717501 0.78282499;
	setAttr -s 9 ".d[0:8]"  -2147483575 -2147483475 -2147483474 -2147483473 -2147483547 -2147483471 
		-2147483470 -2147483469 -2147483575;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit12";
	rename -uid "E4B76EA0-4B86-5E53-48D0-54BCAD45AFB5";
	setAttr -s 9 ".e[0:8]"  0.79002303 0.209977 0.209977 0.209977 0.79002303
		 0.209977 0.209977 0.209977 0.79002303;
	setAttr -s 9 ".d[0:8]"  -2147483575 -2147483507 -2147483506 -2147483505 -2147483547 -2147483503 
		-2147483502 -2147483501 -2147483575;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "Module2:polyTweak3";
	rename -uid "5E033BA0-4708-6D47-C972-D88733FDEDE6";
	setAttr ".uopa" yes;
	setAttr -s 88 ".tk[0:87]" -type "float3"  3.3378601e-006 5.9604645e-008
		 0 22.32648087 0 0 3.3378601e-006 0 0 22.32648087 -2.1606684e-006 -3.8146973e-006
		 3.3378601e-006 0 0 22.32648087 -2.1606684e-006 -9.5367432e-007 3.3378601e-006 0 0
		 22.32648087 0 5.5511151e-016 8.9406967e-008 1.9073486e-006 2.3841858e-007 8.9406967e-008
		 -9.5367432e-007 8.9406967e-008 -8.9406967e-008 0.59471858 -5.5511151e-017 -8.9406967e-008
		 0.59471822 -2.9802322e-008 0 -3.8146973e-006 2.3841858e-007 0 3.68009806 -8.8817842e-016
		 0 3.68009806 -5.5511151e-016 0 8.3446503e-007 4.7683716e-007 0 0 0 0 3.68009806 -8.8817842e-016
		 0 3.68009806 -5.5511151e-016 0 0 2.3841858e-007 0 0 -1.1920929e-007 1.41886973 0.98489118
		 -2.2351742e-008 1.41886973 0.98489118 -2.2351742e-008 0 0 -2.9802322e-008 2.3841858e-006
		 -9.5367432e-007 0 2.3841858e-006 -1.9073486e-006 -1.1920929e-007 2.3841858e-006 1.4901161e-008
		 3.7252903e-009 2.3841858e-006 -2.3841858e-007 5.9604645e-008 3.3378601e-006 5.9604645e-008
		 0 2.3841858e-006 -9.5367432e-007 0 8.9406967e-008 1.9073486e-006 7.0780516e-008 0
		 0.84879184 -1.1920929e-007 0 0.84879082 0 0 0.20133062 5.9604645e-008 22.32648087
		 -3.3527613e-007 4.7683716e-007 22.32648087 -3.3527613e-007 -2.9802321e-008 0 0.20133062
		 8.9406967e-008 0 0.84879082 2.3841858e-007 0 0.84879065 0 8.9406967e-008 -1.4305115e-006
		 5.9604645e-008 2.3841858e-006 -9.5367432e-007 1.1920929e-007 3.3378601e-006 0 0 3.3378601e-006
		 0 0 2.3841858e-006 -7.1525574e-007 0 8.9406967e-008 0.29560304 -2.9802322e-008 0
		 2.65728641 1.4901161e-008 0 2.65728641 1.4901161e-008 0 1.16839659 9.3132257e-009
		 22.32648087 -6.8545341e-007 -9.5367432e-007 22.32648087 -6.8545341e-007 -3.8146973e-006
		 0 1.16839659 -2.9802322e-008 0 2.65728641 0 0 2.65728402 0 8.9406967e-008 0.29560471
		 -2.7008355e-007 2.3841858e-006 -9.5367432e-007 -1.1920929e-007 3.3378601e-006 -2.9802322e-008
		 -7.4505806e-009 0 0 -2.3841858e-007 -9.3132257e-010 -4.6566129e-010 -1.7881393e-007
		 -2.3841858e-007 0 -1.7881393e-007 1.4812212 6.62384415 3.5762787e-007 1.4812212 6.62384415
		 3.5762787e-007 -2.3841858e-007 0 -1.1920929e-007 -9.3132257e-010 -4.6566129e-010
		 0 0 0 -1.1920929e-007 2.9802322e-008 3.4831464e-007 -1.110223e-016 0 0 0 0 0 -3.5762787e-007
		 2.9802322e-008 3.4831464e-007 -3.5762787e-007 0 -1.7955899e-006 1.7881393e-007 -2.41755104
		 6.6238451 -5.2154064e-007 -2.41755104 6.6238451 -3.5017729e-007 0 -1.7955899e-006
		 1.1920929e-007 4.7683716e-007 5.1921234e-008 2.3841858e-007 4.7683716e-007 0 2.220446e-016
		 4.7683716e-007 0 -4.7683716e-007 4.7683716e-007 5.1921234e-008 -1.0728836e-006 4.7683716e-007
		 -4.0605664e-007 -3.9339066e-006 -2.35519791 -1.5124679e-006 -3.8146973e-006 -2.35519791
		 -1.5124679e-006 -1.9073486e-006 4.7683716e-007 -4.0605664e-007 1.5497208e-006 0 1.9073486e-006
		 5.9604645e-008 0 4.7683716e-007 0 0 0.48430347 0 0 1.87337315 -1.6653345e-016 0 2.69903517
		 -3.8857806e-016 0 2.69903517 0 0 1.87337363 -1.0430813e-007 0 0.48430824 0;
createNode polySplit -n "Module2:polySplit11";
	rename -uid "FB1DA1AD-48A3-14AE-3079-A58516AD39DF";
	setAttr -s 9 ".e[0:8]"  0.53111202 0.53111202 0.46888801 0.53111202
		 0.53111202 0.53111202 0.46888801 0.53111202 0.53111202;
	setAttr -s 9 ".d[0:8]"  -2147483636 -2147483635 -2147483572 -2147483552 -2147483634 -2147483633 
		-2147483544 -2147483580 -2147483636;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit10";
	rename -uid "EA9E6EC8-4636-8509-C706-D883230B604E";
	setAttr -s 9 ".e[0:8]"  0.493819 0.506181 0.506181 0.506181 0.493819
		 0.506181 0.506181 0.506181 0.493819;
	setAttr -s 9 ".d[0:8]"  -2147483575 -2147483523 -2147483522 -2147483521 -2147483547 -2147483519 
		-2147483518 -2147483517 -2147483575;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit9";
	rename -uid "A7A549CE-44A2-1DE5-02CF-37B5BF1B47EB";
	setAttr -s 9 ".e[0:8]"  0.68689901 0.31310099 0.31310099 0.31310099
		 0.68689901 0.31310099 0.31310099 0.31310099 0.68689901;
	setAttr -s 9 ".d[0:8]"  -2147483575 -2147483533 -2147483540 -2147483539 -2147483547 -2147483537 
		-2147483536 -2147483535 -2147483575;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit8";
	rename -uid "61633658-4EE0-E870-1771-538D20960FCC";
	setAttr -s 9 ".e[0:8]"  0.280498 0.280498 0.71950197 0.280498 0.280498
		 0.280498 0.71950197 0.280498 0.280498;
	setAttr -s 9 ".d[0:8]"  -2147483612 -2147483577 -2147483547 -2147483611 -2147483610 -2147483549 
		-2147483575 -2147483609 -2147483612;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "Module2:polyTweak2";
	rename -uid "5F329A47-471B-15EA-7EE2-EA806906EA52";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[1]" -type "float3" 19.215187 0 -8.8817842e-016 ;
	setAttr ".tk[3]" -type "float3" 19.215187 0 -8.8817842e-016 ;
	setAttr ".tk[5]" -type "float3" 19.215187 0 -5.5511151e-016 ;
	setAttr ".tk[7]" -type "float3" 19.215187 0 -5.5511151e-016 ;
	setAttr ".tk[34]" -type "float3" 19.215187 0 -8.8817842e-016 ;
	setAttr ".tk[35]" -type "float3" 19.215187 0 -5.5511151e-016 ;
	setAttr ".tk[48]" -type "float3" 19.215187 0 -5.5511151e-016 ;
	setAttr ".tk[49]" -type "float3" 19.215187 0 -8.8817842e-016 ;
createNode polySplit -n "Module2:polySplit7";
	rename -uid "054E43C8-496B-DAB0-C877-90A20285B8C5";
	setAttr -s 15 ".e[0:14]"  0.519036 0.480964 0.480964 0.519036 0.519036
		 0.519036 0.519036 0.480964 0.480964 0.480964 0.480964 0.519036 0.519036 0.480964
		 0.519036;
	setAttr -s 15 ".d[0:14]"  -2147483640 -2147483584 -2147483585 -2147483622 -2147483614 -2147483606 
		-2147483639 -2147483590 -2147483591 -2147483592 -2147483593 -2147483629 -2147483597 -2147483596 -2147483640;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit6";
	rename -uid "2418DD1B-4C18-C8B0-8BC3-7F8AB512656B";
	setAttr -s 15 ".e[0:14]"  0.335601 0.66439903 0.66439903 0.335601 0.335601
		 0.335601 0.335601 0.66439903 0.66439903 0.66439903 0.66439903 0.335601 0.335601 0.66439903
		 0.335601;
	setAttr -s 15 ".d[0:14]"  -2147483644 -2147483597 -2147483629 -2147483624 -2147483616 -2147483608 
		-2147483643 -2147483639 -2147483606 -2147483614 -2147483622 -2147483631 -2147483599 -2147483640 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit5";
	rename -uid "43F2319F-4D36-DA1E-1615-BD8CF495B2E5";
	setAttr -s 5 ".e[0:4]"  0.54168302 0.54168302 0.54168302 0.54168302
		 0.54168302;
	setAttr -s 5 ".d[0:4]"  -2147483648 -2147483645 -2147483646 -2147483647 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit4";
	rename -uid "FA737E28-4A01-03D6-A28E-DAAE52BDD2E1";
	setAttr -s 5 ".e[0:4]"  0.563775 0.563775 0.563775 0.563775 0.563775;
	setAttr -s 5 ".d[0:4]"  -2147483620 -2147483619 -2147483618 -2147483617 -2147483620;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit3";
	rename -uid "840F91D6-410B-4F3A-A187-67A3812EA3F1";
	setAttr -s 5 ".e[0:4]"  0.41997799 0.41997799 0.41997799 0.41997799
		 0.41997799;
	setAttr -s 5 ".d[0:4]"  -2147483628 -2147483627 -2147483626 -2147483625 -2147483628;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit2";
	rename -uid "B8F5BF8B-4458-58DC-1E30-73B90E8C976B";
	setAttr -s 5 ".e[0:4]"  0.321632 0.321632 0.321632 0.321632 0.321632;
	setAttr -s 5 ".d[0:4]"  -2147483636 -2147483633 -2147483634 -2147483635 -2147483636;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "Module2:polySplit1";
	rename -uid "420497F8-4828-B158-7836-D0BF5EFF06E2";
	setAttr -s 5 ".e[0:4]"  0.27184999 0.27184999 0.27184999 0.27184999
		 0.27184999;
	setAttr -s 5 ".d[0:4]"  -2147483648 -2147483645 -2147483646 -2147483647 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "Module2:polyTweak1";
	rename -uid "929FB47A-4ECB-9DD0-9645-4BB31BDE5FC9";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk[0:7]" -type "float3"  -9.36788845 0 5.34545469 20.24028015
		 0 5.34545469 -9.36788845 8.97568893 5.34545469 20.24028015 8.97568893 5.34545469
		 -9.36788845 8.97568893 3.3378601e-006 20.24028015 8.97568893 3.3378601e-006 -9.36788845
		 0 3.3378601e-006 20.24028015 0 3.3378601e-006;
createNode polyCube -n "Module2:polyCube1";
	rename -uid "A03545C0-4883-0602-3321-98BEE97395E2";
	setAttr ".cuv" 4;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
	setAttr -s 5 ".r";
select -ne :initialShadingGroup;
	setAttr -s 13 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 9 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "Module2:polySplit16.out" "Module2:pCubeShape1.i";
connectAttr "Module2:polySplit15.out" "Module2:polySplit16.ip";
connectAttr "Module2:polySplit14.out" "Module2:polySplit15.ip";
connectAttr "Module2:polySplit13.out" "Module2:polySplit14.ip";
connectAttr "Module2:polySplit12.out" "Module2:polySplit13.ip";
connectAttr "Module2:polyTweak3.out" "Module2:polySplit12.ip";
connectAttr "Module2:polySplit11.out" "Module2:polyTweak3.ip";
connectAttr "Module2:polySplit10.out" "Module2:polySplit11.ip";
connectAttr "Module2:polySplit9.out" "Module2:polySplit10.ip";
connectAttr "Module2:polySplit8.out" "Module2:polySplit9.ip";
connectAttr "Module2:polyTweak2.out" "Module2:polySplit8.ip";
connectAttr "Module2:polySplit7.out" "Module2:polyTweak2.ip";
connectAttr "Module2:polySplit6.out" "Module2:polySplit7.ip";
connectAttr "Module2:polySplit5.out" "Module2:polySplit6.ip";
connectAttr "Module2:polySplit4.out" "Module2:polySplit5.ip";
connectAttr "Module2:polySplit3.out" "Module2:polySplit4.ip";
connectAttr "Module2:polySplit2.out" "Module2:polySplit3.ip";
connectAttr "Module2:polySplit1.out" "Module2:polySplit2.ip";
connectAttr "Module2:polyTweak1.out" "Module2:polySplit1.ip";
connectAttr "Module2:polyCube1.out" "Module2:polyTweak1.ip";
connectAttr "Module2:pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of Module2.ma
