﻿function select() {
    var city = document.getElementById("City").value;
    var district = document.getElementById("District");
    if (city == "臺北市") {
        let data = ['中正區', '萬華區', '大同區', '中山區', '松山區', '大安區', '信義區', '內湖區', '南港區', '士林區', '北投區', '文山區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "新北市") {
        let data = ['板橋區', '三重區', '中和區', '永和區', '新莊區', '新店區', '樹林區', '鶯歌區', '三峽區', '淡水區', '金山區', '萬里區', '汐止區', '瑞芳區', '貢寮區', '平溪區', '雙溪區', '新店區', '菜寮區', '土城區', '三芝區', '石門區', '八里區', '平鎮區', '林口區', '復興區', '深坑區', '石碇區', '坪林區', '三芝區', '石門區', '八里區', '平鎮區', '林口區', '復興區', '蘆洲區', '五股區', '泰山區', '林園區', '內門區', '淡水區', '三芝區', '石門區', '八里區', '平鎮區', '林口區', '復興區', '蘆洲區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "桃園市") {
        let data = ['中壢區', '平鎮區', '龍潭區', '楊梅區', '新屋區', '觀音區', '桃園區', '龜山區', '八德區', '大溪區', '復興區', '大園區', '蘆竹區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "臺中市") {
        let data = ['中區', '東區', '南區', '西區', '北區', '北屯區', '西屯區', '南屯區', '太平區', '大里區', '霧峰區', '烏日區', '豐原區', '后里區', '石岡區', '東勢區', '和平區', '新社區', '潭子區', '大雅區', '神岡區', '大肚區', '沙鹿區', '龍井區', '梧棲區', '清水區', '大甲區', '外埔區', '大安區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "臺南市") {
        let data = ['中西區', '東區', '南區', '北區', '安平區', '安南區', '永康區', '歸仁區', '新化區', '左鎮區', '玉井區', '楠西區', '南化區', '仁德區', '關廟區', '龍崎區', '官田區', '麻豆區', '佳里區', '西港區', '七股區', '將軍區', '學甲區', '北門區', '新營區', '後壁區', '白河區', '東山區', '六甲區', '下營區', '柳營區', '鹽水區', '善化區', '大內區', '山上區', '新市區', '安定區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "高雄市") {
        let data = ['新興區', '前金區', '苓雅區', '鹽埕區', '鼓山區', '旗津區', '前鎮區', '三民區', '楠梓區', '小港區', '左營區', '仁武區', '大社區', '岡山區', '路竹區', '阿蓮區', '田寮區', '燕巢區', '橋頭區', '梓官區', '彌陀區', '永安區', '湖內區', '鳳山區', '大寮區', '林園區', '鳥松區', '大樹區', '旗山區', '美濃區', '六龜區', '內門區', '杉林區', '甲仙區', '桃源區', '那瑪夏區', '茂林區', '茄萣區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "宜蘭縣") {
        let data = ['宜蘭市', '頭城鎮', '礁溪鄉', '壯圍鄉', '員山鄉', '羅東鎮', '三星鄉', '大同鄉', '五結鄉', '冬山鄉', '蘇澳鎮', '南澳鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "新竹縣") {
        let data = ['竹北市', '竹東鎮', '新埔鎮', '關西鎮', '新豐鄉', '峨眉鄉', '寶山鄉', '五峰鄉', '橫山鄉', '北埔鄉', '尖石鄉', '芎林鄉', '湖口鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "苗栗縣") {
        let data = ['竹南鎮', '頭份鎮', '三灣鄉', '南庄鄉', '獅潭鄉', '後龍鎮', '通霄鎮', '苑裡鎮', '苗栗市', '造橋鄉', '頭屋鄉', '公館鄉', '大湖鄉', '泰安鄉', '銅鑼鄉', '三義鄉', '西湖鄉', '卓蘭鎮'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "彰化縣") {
        let data = ['彰化市', '芬園鄉', '花壇鄉', '秀水鄉', '鹿港鎮', '福興鄉', '線西鄉', '和美鎮', '伸港鄉', '員林鎮', '社頭鄉', '永靖鄉', '埔心鄉', '溪湖鎮', '大村鄉', '埔鹽鄉', '田中鎮', '北斗鎮', '田尾鄉', '埤頭鄉', '溪州鄉', '竹塘鄉', '二林鎮', '大城鄉', '芳苑鄉', '二水鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "南投縣") {
        let data = ['南投市', '中寮鄉', '草屯鎮', '國姓鄉', '埔里鎮', '仁愛鄉', '名間鄉', '集集鎮', '水里鄉', '魚池鄉', '信義鄉', '竹山鎮', '鹿谷鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "雲林縣") {
        let data = ['斗六市', '斗南鎮', '虎尾鎮', '西螺鎮', '土庫鎮', '北港鎮', '林內鄉', '古坑鄉', '大埤鄉', '崙背鄉', '二崙鄉', '麥寮鄉', '臺西鄉', '東勢鄉', '元長鄉', '四湖鄉', '口湖鄉', '水林鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "嘉義縣") {
        let data = ['太保市', '朴子市', '布袋鎮', '大林鎮', '民雄鄉', '溪口鄉', '新港鄉', '六腳鄉', '東石鄉', '義竹鄉', '鹿草鄉', '水上鄉', '中埔鄉', '竹崎鄉', '梅山鄉', '番路鄉', '大埔鄉', '阿里山鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "屏東縣") {
        let data = ['屏東市', '潮州鎮', '東港鎮', '恆春鎮', '萬丹鄉', '長治鄉', '麟洛鄉', '九如鄉', '里港鄉', '鹽埔鄉', '高樹鄉', '萬巒鄉', '內埔鄉', '竹田鄉', '新埤鄉', '枋寮鄉', '新園鄉', '崁頂鄉', '林邊鄉', '南州鄉', '佳冬鄉', '琉球鄉', '車城鄉', '滿州鄉', '枋山鄉', '三地門鄉', '霧台鄉', '瑪家鄉', '泰武鄉', '來義鄉', '春日鄉', '獅子鄉', '牡丹鄉', '三地鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "臺東縣") {
        let data = ['臺東市', '成功鎮', '關山鎮', '長濱鄉', '池上鄉', '東河鄉', '鹿野鄉', '卑南鄉', '大武鄉', '綠島鄉', '太麻里鄉', '海端鄉', '延平鄉', '金峰鄉', '達仁鄉', '蘭嶼鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "花蓮縣") {
        let data = ['花蓮市', '鳳林鎮', '玉里鎮', '新城鄉', '吉安鄉', '壽豐鄉', '光復鄉', '豐濱鄉', '瑞穗鄉', '萬榮鄉', '富里鄉', '卓溪鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "澎湖縣") {
        let data = ['馬公市', '西嶼鄉', '望安鄉', '七美鄉', '白沙鄉', '湖西鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "基隆市") {
        let data = ['仁愛區', '信義區', '中正區', '中山區', '安樂區', '暖暖區', '七堵區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "新竹市") {
        let data = ['東區', '北區', '香山區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "嘉義市") {
        let data = ['東區', '西區'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "連江縣") {
        let data = ['南竿鄉', '北竿鄉', '莒光鄉', '東引鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    } else if (city == "金門縣") {
        let data = ['金沙鎮', '金湖鎮', '金寧鄉', '金城鎮', '烈嶼鄉', '烏坵鄉'];
        let x = "";
        for (let i = 0; i < data.length; i++) {
            x = x + "<option>" + data[i] + "</option>"
        }
        district.innerHTML = `<option value="">請選擇區域</option>` + x;
    }
}