#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cwrc =
    let _prefixId = PrefixId.fromNamespaceLabel "http://sparql.cwrc.ca/ontologies/cwrc#" "cwrc"

    let _04b840aa_9c38_4e36_8d7c_21b38e192646 = _prefixId.prefix "04b840aa-9c38-4e36-8d7c-21b38e192646"

    let _04b840aa_9c38_4e36_8d7c_21b38e192646_1e19da2a76 = _prefixId.prefix "04b840aa-9c38-4e36-8d7c-21b38e192646-1e19da2a76"

    let _04b840aa_9c38_4e36_8d7c_21b38e192646_5d410f84e2 = _prefixId.prefix "04b840aa-9c38-4e36-8d7c-21b38e192646-5d410f84e2"

    let _04b840aa_9c38_4e36_8d7c_21b38e192646_dd5a878fc2 = _prefixId.prefix "04b840aa-9c38-4e36-8d7c-21b38e192646-dd5a878fc2"

    let _06e019b1_2bad_4fc2_8666_6f374a2e246a = _prefixId.prefix "06e019b1-2bad-4fc2-8666-6f374a2e246a"

    let _06e019b1_2bad_4fc2_8666_6f374a2e246a_3fb34a38c8 = _prefixId.prefix "06e019b1-2bad-4fc2-8666-6f374a2e246a-3fb34a38c8"

    let _06e019b1_2bad_4fc2_8666_6f374a2e246a_partof = _prefixId.prefix "06e019b1-2bad-4fc2-8666-6f374a2e246a-partof"

    let _2002eb96_4775_4ae0_ba0f_6704c30264a9 = _prefixId.prefix "2002eb96-4775-4ae0-ba0f-6704c30264a9"

    let _2002eb96_4775_4ae0_ba0f_6704c30264a9_48185cb881 = _prefixId.prefix "2002eb96-4775-4ae0-ba0f-6704c30264a9-48185cb881"

    let _2002eb96_4775_4ae0_ba0f_6704c30264a9_8d87593063 = _prefixId.prefix "2002eb96-4775-4ae0-ba0f-6704c30264a9-8d87593063"

    let _20b2549d_ee16_45e2_8f42_5e369da2ae0f = _prefixId.prefix "20b2549d-ee16-45e2-8f42-5e369da2ae0f"

    let _20b2549d_ee16_45e2_8f42_5e369da2ae0f_058f6f7211 = _prefixId.prefix "20b2549d-ee16-45e2-8f42-5e369da2ae0f-058f6f7211"

    let _20b2549d_ee16_45e2_8f42_5e369da2ae0f_c18718c096 = _prefixId.prefix "20b2549d-ee16-45e2-8f42-5e369da2ae0f-c18718c096"

    let _20f0c9a2_4cc1_4838_87a5_3b6df3b0a24b = _prefixId.prefix "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b"

    let _20f0c9a2_4cc1_4838_87a5_3b6df3b0a24b_769103a942 = _prefixId.prefix "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-769103a942"

    let _20f0c9a2_4cc1_4838_87a5_3b6df3b0a24b_ecfae99691 = _prefixId.prefix "20f0c9a2-4cc1-4838-87a5-3b6df3b0a24b-ecfae99691"

    let _21bad544_af11_4b8d_869f_2d26f53943c8 = _prefixId.prefix "21bad544-af11-4b8d-869f-2d26f53943c8"

    let _21bad544_af11_4b8d_869f_2d26f53943c8_027917040a = _prefixId.prefix "21bad544-af11-4b8d-869f-2d26f53943c8-027917040a"

    let _21bad544_af11_4b8d_869f_2d26f53943c8_partof = _prefixId.prefix "21bad544-af11-4b8d-869f-2d26f53943c8-partof"

    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58 = _prefixId.prefix "2237f8bc-6be9-44b5-8fe9-f531c6a44a58"

    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58_9796ffdebf = _prefixId.prefix "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-9796ffdebf"

    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58_cdc9f758b8 = _prefixId.prefix "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-cdc9f758b8"

    let _2237f8bc_6be9_44b5_8fe9_f531c6a44a58_da81d2bb55 = _prefixId.prefix "2237f8bc-6be9-44b5-8fe9-f531c6a44a58-da81d2bb55"

    let _23ad5d2a_605e_4116_8f81_7db6b95395ea = _prefixId.prefix "23ad5d2a-605e-4116-8f81-7db6b95395ea"

    let _23ad5d2a_605e_4116_8f81_7db6b95395ea_35ae67fab9 = _prefixId.prefix "23ad5d2a-605e-4116-8f81-7db6b95395ea-35ae67fab9"

    let _23ad5d2a_605e_4116_8f81_7db6b95395ea_7d8f197f96 = _prefixId.prefix "23ad5d2a-605e-4116-8f81-7db6b95395ea-7d8f197f96"

    let _23ad5d2a_605e_4116_8f81_7db6b95395ea_86b08955b2 = _prefixId.prefix "23ad5d2a-605e-4116-8f81-7db6b95395ea-86b08955b2"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6 = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_cdc669be47 = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-cdc669be47"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_2a0b3739d4 = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-2a0b3739d4"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_327d5213ef = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-327d5213ef"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_63a2ae33d9 = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-63a2ae33d9"

    let _26ad3610_a0bb_4e62_8fbc_d6be9ccbbdf6_partof_7e070c5373 = _prefixId.prefix "26ad3610-a0bb-4e62-8fbc-d6be9ccbbdf6-partof-7e070c5373"

    let _26cf15ba_5650_43ef_9a55_229c7ce3bbbb = _prefixId.prefix "26cf15ba-5650-43ef-9a55-229c7ce3bbbb"

    let _26cf15ba_5650_43ef_9a55_229c7ce3bbbb_318cb143c9 = _prefixId.prefix "26cf15ba-5650-43ef-9a55-229c7ce3bbbb-318cb143c9"

    let _26cf15ba_5650_43ef_9a55_229c7ce3bbbb_8b8a0c6d52 = _prefixId.prefix "26cf15ba-5650-43ef-9a55-229c7ce3bbbb-8b8a0c6d52"

    let _27faa9ed_1d5c_44c4_b3f3_e6ac3f57e5f9 = _prefixId.prefix "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9"

    let _27faa9ed_1d5c_44c4_b3f3_e6ac3f57e5f9_5f1ecef571 = _prefixId.prefix "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-5f1ecef571"

    let _27faa9ed_1d5c_44c4_b3f3_e6ac3f57e5f9_84fe24be76 = _prefixId.prefix "27faa9ed-1d5c-44c4-b3f3-e6ac3f57e5f9-84fe24be76"

    let _3238e1a7_6d28_49ed_a48a_cb2cb5e3d1cc = _prefixId.prefix "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc"

    let _3238e1a7_6d28_49ed_a48a_cb2cb5e3d1cc_5cdc250d3f = _prefixId.prefix "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-5cdc250d3f"

    let _3238e1a7_6d28_49ed_a48a_cb2cb5e3d1cc_e3d3563976 = _prefixId.prefix "3238e1a7-6d28-49ed-a48a-cb2cb5e3d1cc-e3d3563976"

    let _366c694c_b5bd_47b4_80a9_2dead4f7a7cb = _prefixId.prefix "366c694c-b5bd-47b4-80a9-2dead4f7a7cb"

    let _366c694c_b5bd_47b4_80a9_2dead4f7a7cb_d59f1c99c3 = _prefixId.prefix "366c694c-b5bd-47b4-80a9-2dead4f7a7cb-d59f1c99c3"

    let _366c694c_b5bd_47b4_80a9_2dead4f7a7cb_fe3a497236 = _prefixId.prefix "366c694c-b5bd-47b4-80a9-2dead4f7a7cb-fe3a497236"

    let _3d49dc32_ac97_4abd_a252_573c52b463cf = _prefixId.prefix "3d49dc32-ac97-4abd-a252-573c52b463cf"

    let _3d49dc32_ac97_4abd_a252_573c52b463cf_c743e92034 = _prefixId.prefix "3d49dc32-ac97-4abd-a252-573c52b463cf-c743e92034"

    let _3d49dc32_ac97_4abd_a252_573c52b463cf_d0e255da83 = _prefixId.prefix "3d49dc32-ac97-4abd-a252-573c52b463cf-d0e255da83"

    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174 = _prefixId.prefix "3f1dd1b1-411b-45a9-a860-7b45bf0a1174"

    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174_a050f81cb4 = _prefixId.prefix "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a050f81cb4"

    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174_a4e96325de = _prefixId.prefix "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-a4e96325de"

    let _3f1dd1b1_411b_45a9_a860_7b45bf0a1174_dbafaea23e = _prefixId.prefix "3f1dd1b1-411b-45a9-a860-7b45bf0a1174-dbafaea23e"

    let _40523fef_509d_4802_900d_4f230fe50123 = _prefixId.prefix "40523fef-509d-4802-900d-4f230fe50123"

    let _40523fef_509d_4802_900d_4f230fe50123_769103a942 = _prefixId.prefix "40523fef-509d-4802-900d-4f230fe50123-769103a942"

    let _40523fef_509d_4802_900d_4f230fe50123_ff80d41ff3 = _prefixId.prefix "40523fef-509d-4802-900d-4f230fe50123-ff80d41ff3"

    let _4dc5ff8c_d908_4377_bca8_9394408b7b67 = _prefixId.prefix "4dc5ff8c-d908-4377-bca8-9394408b7b67"

    let _4dc5ff8c_d908_4377_bca8_9394408b7b67_f3dac63164 = _prefixId.prefix "4dc5ff8c-d908-4377-bca8-9394408b7b67-f3dac63164"

    let _4dc5ff8c_d908_4377_bca8_9394408b7b67_partof = _prefixId.prefix "4dc5ff8c-d908-4377-bca8-9394408b7b67-partof"

    let _4f4d7ca6_5625_46d9_bd88_17847ee076d8 = _prefixId.prefix "4f4d7ca6-5625-46d9-bd88-17847ee076d8"

    let _4f4d7ca6_5625_46d9_bd88_17847ee076d8_63a2ae33d9 = _prefixId.prefix "4f4d7ca6-5625-46d9-bd88-17847ee076d8-63a2ae33d9"

    let _4f4d7ca6_5625_46d9_bd88_17847ee076d8_9141ebf465 = _prefixId.prefix "4f4d7ca6-5625-46d9-bd88-17847ee076d8-9141ebf465"

    let _59f48ef6_ebc7_4a58_ac43_2025deb369ec = _prefixId.prefix "59f48ef6-ebc7-4a58-ac43-2025deb369ec"

    let _59f48ef6_ebc7_4a58_ac43_2025deb369ec_842232a3cd = _prefixId.prefix "59f48ef6-ebc7-4a58-ac43-2025deb369ec-842232a3cd"

    let _59f48ef6_ebc7_4a58_ac43_2025deb369ec_partof = _prefixId.prefix "59f48ef6-ebc7-4a58-ac43-2025deb369ec-partof"

    let _5e3f3ab7_be20_4dc5_91ec_f41946e05e28 = _prefixId.prefix "5e3f3ab7-be20-4dc5-91ec-f41946e05e28"

    let _5e3f3ab7_be20_4dc5_91ec_f41946e05e28_5618f6070b = _prefixId.prefix "5e3f3ab7-be20-4dc5-91ec-f41946e05e28-5618f6070b"

    let _5e3f3ab7_be20_4dc5_91ec_f41946e05e28_63a2ae33d9 = _prefixId.prefix "5e3f3ab7-be20-4dc5-91ec-f41946e05e28-63a2ae33d9"

    let _5e45242f_0c2e_4aaa_8ddb_ac54dd0e6249 = _prefixId.prefix "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249"

    let _5e45242f_0c2e_4aaa_8ddb_ac54dd0e6249_13cadb9dc7 = _prefixId.prefix "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-13cadb9dc7"

    let _5e45242f_0c2e_4aaa_8ddb_ac54dd0e6249_43b2d638e3 = _prefixId.prefix "5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249-43b2d638e3"

    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc = _prefixId.prefix "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc"

    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_352a867f1c = _prefixId.prefix "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-352a867f1c"

    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_706552b3f4 = _prefixId.prefix "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-706552b3f4"

    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_partof = _prefixId.prefix "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof"

    let _62208dcb_ed1f_4612_8433_d6e4e5e0b7fc_partof_72abfae814 = _prefixId.prefix "62208dcb-ed1f-4612-8433-d6e4e5e0b7fc-partof-72abfae814"

    let _65424c4e_5257_4e6c_962f_de12a7f11aea = _prefixId.prefix "65424c4e-5257-4e6c-962f-de12a7f11aea"

    let _65424c4e_5257_4e6c_962f_de12a7f11aea_215ee9c7d9 = _prefixId.prefix "65424c4e-5257-4e6c-962f-de12a7f11aea-215ee9c7d9"

    let _65424c4e_5257_4e6c_962f_de12a7f11aea_partof = _prefixId.prefix "65424c4e-5257-4e6c-962f-de12a7f11aea-partof"

    let _65424c4e_5257_4e6c_962f_de12a7f11aea_partof_215ee9c7d9 = _prefixId.prefix "65424c4e-5257-4e6c-962f-de12a7f11aea-partof-215ee9c7d9"

    let _65424c4e_5257_4e6c_962f_de12a7f11aea_partof_712daeb456 = _prefixId.prefix "65424c4e-5257-4e6c-962f-de12a7f11aea-partof-712daeb456"

    let _6addf580_24e2_4750_9d2a_aa6dd66032a6 = _prefixId.prefix "6addf580-24e2-4750-9d2a-aa6dd66032a6"

    let _6addf580_24e2_4750_9d2a_aa6dd66032a6_215ee9c7d9 = _prefixId.prefix "6addf580-24e2-4750-9d2a-aa6dd66032a6-215ee9c7d9"

    let _6addf580_24e2_4750_9d2a_aa6dd66032a6_partof = _prefixId.prefix "6addf580-24e2-4750-9d2a-aa6dd66032a6-partof"

    let _713873c7_011a_4b34_b5dc_d6d147575119 = _prefixId.prefix "713873c7-011a-4b34-b5dc-d6d147575119"

    let _713873c7_011a_4b34_b5dc_d6d147575119_37765af5b7 = _prefixId.prefix "713873c7-011a-4b34-b5dc-d6d147575119-37765af5b7"

    let _713873c7_011a_4b34_b5dc_d6d147575119_partof = _prefixId.prefix "713873c7-011a-4b34-b5dc-d6d147575119-partof"

    let _727d97bc_af78_4122_94be_aa78b2e97d5a = _prefixId.prefix "727d97bc-af78-4122-94be-aa78b2e97d5a"

    let _727d97bc_af78_4122_94be_aa78b2e97d5a_17b91d1c8c = _prefixId.prefix "727d97bc-af78-4122-94be-aa78b2e97d5a-17b91d1c8c"

    let _72ce1f91_b3d5_4b7b_8b76_dc674513bec1 = _prefixId.prefix "72ce1f91-b3d5-4b7b-8b76-dc674513bec1"

    let _72ce1f91_b3d5_4b7b_8b76_dc674513bec1_4c365f6a6e = _prefixId.prefix "72ce1f91-b3d5-4b7b-8b76-dc674513bec1-4c365f6a6e"

    let _72ce1f91_b3d5_4b7b_8b76_dc674513bec1_f1c3424826 = _prefixId.prefix "72ce1f91-b3d5-4b7b-8b76-dc674513bec1-f1c3424826"

    let _734cd035_459b_407e_8a08_b68cd2bb743a = _prefixId.prefix "734cd035-459b-407e-8a08-b68cd2bb743a"

    let _734cd035_459b_407e_8a08_b68cd2bb743a_b79efa6e1c = _prefixId.prefix "734cd035-459b-407e-8a08-b68cd2bb743a-b79efa6e1c"

    let _75660bb0_b804_428e_8efb_c139bc7a63d6 = _prefixId.prefix "75660bb0-b804-428e-8efb-c139bc7a63d6"

    let _75660bb0_b804_428e_8efb_c139bc7a63d6_8471bb905b = _prefixId.prefix "75660bb0-b804-428e-8efb-c139bc7a63d6-8471bb905b"

    let _75660bb0_b804_428e_8efb_c139bc7a63d6_9341b4f3e5 = _prefixId.prefix "75660bb0-b804-428e-8efb-c139bc7a63d6-9341b4f3e5"

    let _75660bb0_b804_428e_8efb_c139bc7a63d6_partof = _prefixId.prefix "75660bb0-b804-428e-8efb-c139bc7a63d6-partof"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8 = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_42d9d30d94 = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8-42d9d30d94"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_706552b3f4 = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8-706552b3f4"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_9f43ebd6db = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8-9f43ebd6db"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_ab964c6950 = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8-ab964c6950"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_cf7aa6a7bf = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8-cf7aa6a7bf"

    let _772b1b45_8046_46b0_a746_bbdc8849a6c8_partof = _prefixId.prefix "772b1b45-8046-46b0-a746-bbdc8849a6c8-partof"

    let _775357d1_e547_4674_9467_50b0308354ca = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca"

    let _775357d1_e547_4674_9467_50b0308354ca_42d9d30d94 = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca-42d9d30d94"

    let _775357d1_e547_4674_9467_50b0308354ca_706552b3f4 = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca-706552b3f4"

    let _775357d1_e547_4674_9467_50b0308354ca_9f43ebd6db = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca-9f43ebd6db"

    let _775357d1_e547_4674_9467_50b0308354ca_ab964c6950 = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca-ab964c6950"

    let _775357d1_e547_4674_9467_50b0308354ca_cf7aa6a7bf = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca-cf7aa6a7bf"

    let _775357d1_e547_4674_9467_50b0308354ca_partof = _prefixId.prefix "775357d1-e547-4674-9467-50b0308354ca-partof"

    let _7b624412_74a3_4560_a038_d59b747ee9c7 = _prefixId.prefix "7b624412-74a3-4560-a038-d59b747ee9c7"

    let _7b624412_74a3_4560_a038_d59b747ee9c7_partof = _prefixId.prefix "7b624412-74a3-4560-a038-d59b747ee9c7-partof"

    let _7c123714_5956_4ce5_bf15_39f3f7c5deed = _prefixId.prefix "7c123714-5956-4ce5-bf15-39f3f7c5deed"

    let _7d891586_52df_49f4_9cef_77e26f1a0ed6 = _prefixId.prefix "7d891586-52df-49f4-9cef-77e26f1a0ed6"

    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_3cddc7f227 = _prefixId.prefix "7d891586-52df-49f4-9cef-77e26f1a0ed6-3cddc7f227"

    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_4d944811ab = _prefixId.prefix "7d891586-52df-49f4-9cef-77e26f1a0ed6-4d944811ab"

    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_706552b3f4 = _prefixId.prefix "7d891586-52df-49f4-9cef-77e26f1a0ed6-706552b3f4"

    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_ff77f5d24a = _prefixId.prefix "7d891586-52df-49f4-9cef-77e26f1a0ed6-ff77f5d24a"

    let _7d891586_52df_49f4_9cef_77e26f1a0ed6_partof = _prefixId.prefix "7d891586-52df-49f4-9cef-77e26f1a0ed6-partof"

    let _7faf2c87_1064_43d7_81b9_90f16068587e = _prefixId.prefix "7faf2c87-1064-43d7-81b9-90f16068587e"

    let _7faf2c87_1064_43d7_81b9_90f16068587e_06e80bcecd = _prefixId.prefix "7faf2c87-1064-43d7-81b9-90f16068587e-06e80bcecd"

    let _7faf2c87_1064_43d7_81b9_90f16068587e_7c9776f33e = _prefixId.prefix "7faf2c87-1064-43d7-81b9-90f16068587e-7c9776f33e"

    let _7faf2c87_1064_43d7_81b9_90f16068587e_ad9e6833cd = _prefixId.prefix "7faf2c87-1064-43d7-81b9-90f16068587e-ad9e6833cd"

    let _7fb45454_7271_48b3_bd57_7a2b4572fc21 = _prefixId.prefix "7fb45454-7271-48b3-bd57-7a2b4572fc21"

    let _7fb45454_7271_48b3_bd57_7a2b4572fc21_215ee9c7d9 = _prefixId.prefix "7fb45454-7271-48b3-bd57-7a2b4572fc21-215ee9c7d9"

    let _7fb45454_7271_48b3_bd57_7a2b4572fc21_afbfc72532 = _prefixId.prefix "7fb45454-7271-48b3-bd57-7a2b4572fc21-afbfc72532"

    let _8049540f_3673_4ca0_920c_cb5326d7c466 = _prefixId.prefix "8049540f-3673-4ca0-920c-cb5326d7c466"

    let _8049540f_3673_4ca0_920c_cb5326d7c466_215ee9c7d9 = _prefixId.prefix "8049540f-3673-4ca0-920c-cb5326d7c466-215ee9c7d9"

    let _8049540f_3673_4ca0_920c_cb5326d7c466_bedac43443 = _prefixId.prefix "8049540f-3673-4ca0-920c-cb5326d7c466-bedac43443"

    let _825995b3_3b66_4e0a_a62d_d8649aaead78 = _prefixId.prefix "825995b3-3b66-4e0a-a62d-d8649aaead78"

    let _825995b3_3b66_4e0a_a62d_d8649aaead78_5336e1be2c = _prefixId.prefix "825995b3-3b66-4e0a-a62d-d8649aaead78-5336e1be2c"

    let _825995b3_3b66_4e0a_a62d_d8649aaead78_63a2ae33d9 = _prefixId.prefix "825995b3-3b66-4e0a-a62d-d8649aaead78-63a2ae33d9"

    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5 = _prefixId.prefix "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5"

    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5_215ee9c7d9 = _prefixId.prefix "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-215ee9c7d9"

    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5_partof = _prefixId.prefix "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof"

    let _842ffbb4_11de_4212_8e6e_9d4d8d28d3a5_partof_215ee9c7d9 = _prefixId.prefix "842ffbb4-11de-4212-8e6e-9d4d8d28d3a5-partof-215ee9c7d9"

    let _8f9744a7_4861_4bd3_a956_e4aab75b7e77 = _prefixId.prefix "8f9744a7-4861-4bd3-a956-e4aab75b7e77"

    let _8f9744a7_4861_4bd3_a956_e4aab75b7e77_010dabac97 = _prefixId.prefix "8f9744a7-4861-4bd3-a956-e4aab75b7e77-010dabac97"

    let _8f9744a7_4861_4bd3_a956_e4aab75b7e77_10865207d0 = _prefixId.prefix "8f9744a7-4861-4bd3-a956-e4aab75b7e77-10865207d0"

    let _8fd7cfcc_7613_4c1c_af44_798d6a3dca4c = _prefixId.prefix "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c"

    let _8fd7cfcc_7613_4c1c_af44_798d6a3dca4c_109da887be = _prefixId.prefix "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-109da887be"

    let _8fd7cfcc_7613_4c1c_af44_798d6a3dca4c_e2ba549b99 = _prefixId.prefix "8fd7cfcc-7613-4c1c-af44-798d6a3dca4c-e2ba549b99"

    let _9144c07e_d14f_4371_8d28_7545b7337a4a = _prefixId.prefix "9144c07e-d14f-4371-8d28-7545b7337a4a"

    let _9144c07e_d14f_4371_8d28_7545b7337a4a_215ee9c7d9 = _prefixId.prefix "9144c07e-d14f-4371-8d28-7545b7337a4a-215ee9c7d9"

    let _9144c07e_d14f_4371_8d28_7545b7337a4a_80d754989b = _prefixId.prefix "9144c07e-d14f-4371-8d28-7545b7337a4a-80d754989b"

    let _9f8246db_bb73_4ad1_ab02_693da46dbd06 = _prefixId.prefix "9f8246db-bb73-4ad1-ab02-693da46dbd06"

    let _9f8246db_bb73_4ad1_ab02_693da46dbd06_5d348c3259 = _prefixId.prefix "9f8246db-bb73-4ad1-ab02-693da46dbd06-5d348c3259"

    let _9f8246db_bb73_4ad1_ab02_693da46dbd06_partof = _prefixId.prefix "9f8246db-bb73-4ad1-ab02-693da46dbd06-partof"

    let AbiLemak = _prefixId.prefix "AbiLemak"
    let AbigelLemak = _prefixId.prefix "AbigelLemak"
    /// <summary>
    ///   <para>skos:definition : A name constructed with the intent to abuse, satirize, or slander. For example, Constance Gore-Booth was known in the press by the nickname of "Red Countess" and this nickname had negative connotations.skos:definition : </para>
    ///   <para>rdfs:label : abusive namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#AbusiveName">cwrc:AbusiveName</a>
    /// </summary>
    let AbusiveName = _prefixId.prefix "AbusiveName"
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>skos:definition : An additional name, "such as a nickname, epithet, or alias." This term is derived from the Text Encoding Initiative P5 schema for the 'addName' element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-addName.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-addName.html"&gt;TEI element addName  (additional name) &lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : additional namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#AdditionalName">cwrc:AdditionalName</a>
    /// </summary>
    let AdditionalName = _prefixId.prefix "AdditionalName"
    /// <summary>
    ///   <para>rdfs:label : addressrdfs:label : adresse</para>
    ///   <para>rdfs:comment : CWRC address is the equivalent of a schema.org Postal Address and uses the predicates from schema Postal Address.</para>
    ///   <para>skos:definition : Une adresse postale ou de rue.skos:definition : A mailing or street address.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Address">cwrc:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    let AlliyyaMo = _prefixId.prefix "AlliyyaMo"
    let Androgynous = _prefixId.prefix "Androgynous"
    /// <summary>
    ///   <para>skos:definition : A name under which a writer wrote or published.skos:definition : </para>
    ///   <para>rdfs:label : authorial namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#AuthorialName">cwrc:AuthorialName</a>
    /// </summary>
    let AuthorialName = _prefixId.prefix "AuthorialName"
    /// <summary>
    ///   <para>skos:definition : Biography Context is a major subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Biography Context provide information about and discussions of a person's biography or personal history, through the use of biographical properties and relationships and through subclasses of Biographical Context such as &lt;a href="#BirthContext" title="#BirthContext"&gt;birth context&lt;/a&gt;, &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;, or &lt;a href="#OccupationContext" title="#OccupationContext"&gt;occupation context&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : biography contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#BiographyContext">cwrc:BiographyContext</a>
    /// </summary>
    let BiographyContext = _prefixId.prefix "BiographyContext"
    /// <summary>
    ///   <para>skos:definition : Classe de &lt;a href="#Context" title="#Context"&gt;contexte&lt;/a&gt; importante. Les annotations entrées en tant que contexte de naissance fournissent des informations sur la naissance d'une personne. Voir &lt;a href="http://dbpedia.org/page/Birth" title="http://dbpedia.org/page/Birth"&gt;About: Birth&lt;/a&gt; skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as birth context provide information about and discussions of a person's birth. See &lt;a href="http://dbpedia.org/page/Birth" title="http://dbpedia.org/page/Birth"&gt;About: Birth&lt;/a&gt;.</para>
    ///   <para>rdfs:label : naissance en contexterdfs:label : birth context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#BirthContext">cwrc:BirthContext</a>
    /// </summary>
    let BirthContext = _prefixId.prefix "BirthContext"
    /// <summary>
    ///   <para>skos:definition : Indique l'ordre de naissance d'une foaf:person, qu'elle soit aînée, cadette ou enfant unique de sa famille. Les déclarations sur l'odre de naissance peuvent être formulées en lien avec les frères et soeurs biologiques, adoptif·ve·s ou par alliance, sans traitement systématique des frères et soeurs décédé·e·s susceptibles de modifier l'ordre de naissance.skos:definition : Indicates the birth position of a foaf:person, that is, whether they are the &lt;a href="#eldestChild" title="#eldestChild"&gt;eldest&lt;/a&gt;, &lt;a href="#youngestChild" title="#youngestChild"&gt;youngest&lt;/a&gt;, or &lt;a href="#onlyChild" title="#onlyChild"&gt;only child&lt;/a&gt; in their family. Birth position claims can be made in relation to biological, adopted, or step siblings, and there is not systematic handling of deceased siblings that might affect one's understanding of birth order.</para>
    ///   <para>rdfs:label : ordre de naissancerdfs:label : birth position</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#BirthPosition">cwrc:BirthPosition</a>
    /// </summary>
    let BirthPosition = _prefixId.prefix "BirthPosition"
    /// <summary>
    ///   <para>skos:definition : Indicates the name a person was assigned at birth.skos:definition : </para>
    ///   <para>rdfs:label : birthnamerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Birthname">cwrc:Birthname</a>
    /// </summary>
    let Birthname = _prefixId.prefix "Birthname"
    /// <summary>
    ///   <para>skos:definition : «Un internat est une branche d'un établissement scolaire (école, collège, lycée, école d'enseignement supérieur...) qui offre la possibilité de loger et nourrir les élèves et les étudiants. À cette fin, un internat comprend généralement un dortoir ou des chambres, un réfectoire et des salles d'études, douche ou de divertissement.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : "A boarding school provides education for pupils who live on the premises, as opposed to a day school. The word "boarding” is used in the sense of "room and board" i.e., lodging and meals. As they have existed for many centuries, and now extend across many countries, their function and ethos varies greatly." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:comment : La description de ce terme est basée sur celle de DBPedia.rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <para>rdfs:label : internatrdfs:label : boarding school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#BoardingSchool">cwrc:BoardingSchool</a>
    /// </summary>
    let BoardingSchool = _prefixId.prefix "BoardingSchool"
    /// <summary>
    ///   <para>skos:definition : An event associated with British women writers, including the creation, publication and reception of their works, as well as the material conditions and other aspects of their lives.skos:definition : </para>
    ///   <para>rdfs:label : british women writers literary climaterdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#BritishWomenLiteraryClimate">cwrc:BritishWomenLiteraryClimate</a>
    /// </summary>
    let BritishWomenLiteraryClimate = _prefixId.prefix "BritishWomenLiteraryClimate"
    /// <summary>
    ///   <para>skos:definition : A bursary is a monetary award made by an institution to individuals or groups of people who cannot afford to pay full fees. In return for the bursary the individual is usually obligated to be employed at the institution for the duration as the bursary.skos:definition : </para>
    ///   <para>rdfs:label : bursaryrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Bursary">cwrc:Bursary</a>
    /// </summary>
    let Bursary = _prefixId.prefix "Bursary"
    /// <summary>
    ///   <para>skos:definition : La probabilité décrit la qualité d'un fait dans l'ontologie. Elle est principalement utilisée pour représenter des informations qui peuvent être des faits non avérés.skos:definition : Certainty describes the quality of a fact in the ontology. It is used primarily to represent information that may not be fact.</para>
    ///   <para>rdfs:label : probabilitérdfs:label : certainty</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Certainty">cwrc:Certainty</a>
    /// </summary>
    let Certainty = _prefixId.prefix "Certainty"
    /// <summary>
    ///   <para>rdfs:label : change setrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : A change set represents changes or additions made to the ontology by ontology editors or through users where instances were affected. Change sets will also be used to translate and contain Orlando recordInfo instances.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ChangeSet">cwrc:ChangeSet</a>
    /// </summary>
    let ChangeSet = _prefixId.prefix "ChangeSet"
    /// <summary>
    ///   <para>rdfs:comment : La description de ce terme est basée sur celle de DBPedia.rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <para>rdfs:label : co-ed schoolrdfs:label : éducation mixte</para>
    ///   <para>skos:definition : "Mixed-sex education, also known as mixed-gender education, co-education or coeducation (abbreviated to co-ed or coed), is a system of education where males and females are educated together. Whereas single-sex education was more common up to the 19th century, mixed-sex education has since become standard in many cultures, particularly in Western countries. Single-sex education, however, remains prevalent in many Muslim countries. The relative merits of both systems have been the subject of debate." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «La mixité ou, dans son sens ancien, la coéducation1 est l'instruction et l'éducation en commun des garçons et des filles, dans des groupes mixtes.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#CoEducationalSchool">cwrc:CoEducationalSchool</a>
    /// </summary>
    let CoEducationalSchool = _prefixId.prefix "CoEducationalSchool"
    let ColinFaulkner = _prefixId.prefix "ColinFaulkner"
    /// <summary>
    ///   <para>skos:definition : Une question qui peut être posée à l’ontologie et servira à déterminer les exigences ontologiques de haut niveau du CSÉC, permettant ainsi de prendre des décisions sur sa structure et ses composants.skos:definition : A question that can be asked of the ontology and will be used to specify the high level requirements of the CWRC Ontology allowing decisions about structure and components to be made.</para>
    ///   <para>rdfs:label : competency questionrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#CompetencyQuestion">cwrc:CompetencyQuestion</a>
    /// </summary>
    let CompetencyQuestion = _prefixId.prefix "CompetencyQuestion"
    /// <summary>
    ///   <para>skos:definition : «Après l'école primaire, on a le choix entre deux types d'établissement : grammar school (lycée) et comprehensive state (lycée général). Pour entrer dans une grammar school, il faut passer un examen nommé "11+". Les Grammar schools étant pour les étudiants les plus doués, et les places étant limitées, la grande majorité des enfants fréquentent les state comprehensive.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : "A comprehensive school is a secondary school or middle school that is a state school and does not select its intake on the basis of academic achievement or aptitude. This is in contrast to the selective school system, where admission is restricted on the basis of selection criteria. The term is commonly used in relation to England and Wales, where comprehensive schools were introduced on an experimental basis in the 1940s and became more widespread from 1965. About 90% of British secondary school pupils now attend comprehensive schools. They correspond broadly to the public high school in the United States and Canada and to the German Gesamtschule." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:label : comprehensive schoolrdfs:label : école</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ComprehensiveSchool">cwrc:ComprehensiveSchool</a>
    /// </summary>
    let ComprehensiveSchool = _prefixId.prefix "ComprehensiveSchool"
    let ConstanceCrompton = _prefixId.prefix "ConstanceCrompton"
    /// <summary>
    ///   <para>skos:definition : The Context class provides the discursive context for assertions in the ontology. Where the assertions have been generated from a source text, Context provides the text, or the relevant snippet of a longer text, from which they have been extracted.skos:definition : </para>
    ///   <para>rdfs:label : contexterdfs:label : context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Context">cwrc:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>skos:definition : Academic or educational qualification, such as a certificate or degree, awarded by an educational institution.skos:definition : </para>
    ///   <para>rdfs:label : credentialrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Credential">cwrc:Credential</a>
    /// </summary>
    let Credential = _prefixId.prefix "Credential"
    /// <summary>
    ///   <para>skos:definition : A name deliberately obscured, as in an anagram. Cryptic names have lexical meaning such as "The Scotch Milkmaid,""A Housewife," or "A Placid Reader." skos:definition : </para>
    ///   <para>rdfs:label : cryptic namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#CrypticName">cwrc:CrypticName</a>
    /// </summary>
    let CrypticName = _prefixId.prefix "CrypticName"
    /// <summary>
    ///   <para>skos:definition : The Cultural Form class of properties associates specific concepts and categories with the process of identity formation through cultural processes. Such associations may be or have been embraced by the subject herself or himself or attributed by others. Although cultural forms or social identities circulate around the notion of characteristics, traditions, beliefs, or origins that are shared with others, recent work has stressed the contingency, provisionality, and constructedness of such categories through both complex discourses and social practices. As argued by Stuart Hall, "It seems to be in the attempt to rearticulate the relationship between subjects and discursive practices that the question of identity recurs" ("Introduction"). See Stuart Hall and Paul du Goy's edited collection Questions of Cultural Identity (&lt;a href="#cwrc:e1f710d3-6ebd-4181-be61-bf931282a8b7"&gt;Paul du Goy and Stuart Hall, 1996&lt;/a&gt;). Given their highly discursive nature, the concepts and categories classed as cultural forms are understood to overlap with each other conceptually. The same word or label can therefore occur as multiple cultural forms, reflecting the shifting discursive contexts in which it has been used and the diverse situations from which it has emerged. Each specific Cultural Form is understood to interact not only with other cultural forms or identity categories applied to a person, and other instances of the form applied to other people, but also always with Cultural Formation Context annotations, which support the understanding that social identities are always constructions in progress.skos:definition : La classe de propriétés Forme Culturelle associe des concepts et des catégories spécifiques à la formation identitaire réalisée au travers de processus culturels. De telles associations ont été adoptées par le sujet elle/lui-même ou attribuées par d'autres. Même si les formes culturelles ou les identités sociales s'articulent autour de notions communément partagées comme la caractérisation, les traditions, les croyances ou les origines, certains travaux récents ont ont montré que de telles catégories sont contingentes, provisoire et construites par des discours et des pratiques sociales complexes. Tel que Stuart Hall l'affirme, "Il semble que la question de l'identité réapparaît dans une tentative de remanier la relation entre sujets et pratiques discursives" ("Introduction"). Voir la collection éditée par Stuart Hall et Paul du Goy, Questions of Cultural Identity (&lt;a href="#cwrc:e1f710d3-6ebd-4181-be61-bf931282a8b7"&gt;(Paul du Goy and Stuart Hall, 1996)&lt;/a&gt;. Comme ils sont de nature discursive, les concepts et les catégories de Formes Culturelles se recoupent. Un même terme peut donc apparaître sous diverses formes culturelles, reflétant le changement de contextes discursifs dans lesquels il est employé et les diverses situations d'où il provient. Chaque Forme Culturelle est d'une part liée aux autres formes culturelles ou catégories identitaires qui sont appliquées à une personne ou à d'autres individus, et est d'autre part toujours reliée aux annotations de Formation Culturelle En Contexte, soutenant que les identités sociales sont toujours considérées comme des constructions en progrès.</para>
    ///   <para>rdfs:label : forme culturellerdfs:label : cultural form</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalForm">cwrc:CulturalForm</a>
    /// </summary>
    let CulturalForm = _prefixId.prefix "CulturalForm"
    /// <summary>
    ///   <para>skos:definition : Formation Culturelle En Contexte est une sous-classe de &lt;a href="#Context" title="#Context"&gt;contexte&lt;/a&gt; importante. Les annotations entrées en tant Formation Culturelle En Contexte fournissent des renseignements et des discussions sur l'identité sociales ou la subjectivité d'une personne à travers l'utilisation des propriétés Formes Culturelles, qui lorsqu'elles sont multiples indiquent souvent des identités intersectionnelles. skos:definition : Cultural Form Context is a significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Cultural Form Context provide information about and discussions of a person's social identity or subjectivity through the use of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; properties, which when multiple often indicate intersectional identities.</para>
    ///   <para>rdfs:label : forme culturelle en contexterdfs:label : cultural form context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#CulturalFormContext">cwrc:CulturalFormContext</a>
    /// </summary>
    let CulturalFormContext = _prefixId.prefix "CulturalFormContext"
    let CulturalFormation = _prefixId.prefix "CulturalFormation"
    /// <summary>
    ///   <para>skos:definition : «On désigne sous le nom de Dame schools les premières écoles primaires privées dans les pays de langue anglaise. C'étaient d'ordinaire des femmes qui enseignaient à leur propre domicile. Il y en avait de toutes sortes : certaines étaient de simples garderies tenues par des femmes analphabètes, alors que d'autres donnaient aux élèves des bases solides. Les lacunes de ce système furent mises en évidence en 1838 par une étude de la Statistical Society of London1. Cette étude affirmait que la moitié des élèves des Dame school n'apprenaient que l'alphabet, une proportion négligeable pratiquant les mathématiques et la grammaire. Les Dame schools se firent plus rares en Grande-Bretagne après que l'enseignement eut été rendu obligatoire en 1880 : les écoles où les cours ne couvraient pas le programme fixé par le gouvernement pouvaient être fermées. Dans la première école d'Australie, qui était une Dame school créée en 1789, c'est une détenue, Isabella Rossen, qui enseignait les bases aux enfants.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : "A dame school was an early form of a private elementary school in English-speaking countries. They were usually taught by women and were often located in the home of the teacher." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>rdfs:label : dame schoolrdfs:label : dame school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#DameSchool">cwrc:DameSchool</a>
    /// </summary>
    let DameSchool = _prefixId.prefix "DameSchool"
    /// <summary>
    ///   <para>rdfs:comment : La description de ce terme est basée sur celle de DBPedia.rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <para>rdfs:label : day schoolrdfs:label : école externe</para>
    ///   <para>skos:definition : "A day school—as opposed to a boarding school—is an institution where children (or high-school age adolescents) are given educational instruction during the day, after which the students return to their homes. The term can also be used to emphasize the length of full-day programs as opposed to after-school programs, as in Jewish day school." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «Une école est un établissement où l'on accueille des individus appelés « écoliers » ou élèves afin que des professeurs leur dispensent un enseignement de façon collective. Le mot école vient du latin schola, signifiant « loisir consacré à l'étude », lui-même provenant du grec schole (« le loisir »note 1), lequel constituait un idéal souvent exprimé par les philosophes et une catégorie socialement valorisée opposée à la sphère des tâches productives.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#DaySchool">cwrc:DaySchool</a>
    /// </summary>
    let DaySchool = _prefixId.prefix "DaySchool"
    /// <summary>
    ///   <para>skos:definition : Classe de &lt;a href="#Context" title="#Context"&gt;contexte&lt;/a&gt; importante. Les annotations entrées comme contexte de décès fournissent des renseignements et des discussions sur le décès de la personne. Voir &lt;a href="http://dbpedia.org/page/Death" title="http://dbpedia.org/page/Death"&gt;About: Death&lt;/a&gt; skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as death context provide information about and discussions of a person's death. See &lt;a href="http://dbpedia.org/page/Death" title="http://dbpedia.org/page/Death"&gt;About: Death&lt;/a&gt;.</para>
    ///   <para>rdfs:label : décès en contexterdfs:label : death context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#DeathContext">cwrc:DeathContext</a>
    /// </summary>
    let DeathContext = _prefixId.prefix "DeathContext"
    let DebStacey = _prefixId.prefix "DebStacey"
    /// <summary>
    ///   <para>skos:definition : Indicates a low level of significance appropriate to a detailed understanding of a decade.skos:definition : </para>
    ///   <para>rdfs:label : decade significancerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#DecadeSignficance">cwrc:DecadeSignficance</a>
    /// </summary>
    let DecadeSignficance = _prefixId.prefix "DecadeSignficance"
    /// <summary>
    ///   <para>skos:definition : An educational award indicating that a person has achieved honours or distinction in their studies.skos:definition : </para>
    ///   <para>rdfs:label : distinctionrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Distinction">cwrc:Distinction</a>
    /// </summary>
    let Distinction = _prefixId.prefix "Distinction"
    /// <summary>
    ///   <para>skos:definition : L'éducation a lieu à domicile. Par exemple, une auteure de la période victorienne qui a reçu son instruction d'un frère ou d'une gouvernante.skos:definition : Context for education that takes place at home. For example, of a woman writer in the Victorian period taught by her brother or a governess.</para>
    ///   <para>rdfs:label : domestic education contextrdfs:label : contexte éducatif domestique</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#DomesticEducationContext">cwrc:DomesticEducationContext</a>
    /// </summary>
    let DomesticEducationContext = _prefixId.prefix "DomesticEducationContext"
    /// <summary>
    ///   <para>skos:definition : Education Context is a significant subclass of context. It has subclasses for &lt;a href="#DomesticEducationContext" title="#DomesticEducationContext"&gt;domestic education context&lt;/a&gt;, &lt;a href="#InstitutionalEducationContext" title="#InstitutionalEducationContext"&gt;institutional education context&lt;/a&gt;, and &lt;a href="#SelfTaughtEducationContext" title="#SelfTaughtEducationContext"&gt;self taught education context&lt;/a&gt;. Annotations typed as Education Context or a subclass provide information about and discussions of a person's education, whether formal or informal.skos:definition : Contexte Éducatif est une sous-classe de contexte important. Elle contient les sous-classes de contexte &lt;a href="#DomesticEducationContext" title="#DomesticEducationContext"&gt;contexte éducatif domestique&lt;/a&gt;, &lt;a href="#InstitutionalEducationContext" title="#InstitutionalEducationContext"&gt;contexte éducatif institutionnel&lt;/a&gt; et &lt;a href="#SelfTaughtEducationContext" title="#SelfTaughtEducationContext"&gt;contexte éducatif autodidacte&lt;/a&gt;. Les annotations entrées en tant que Contexte Éducatif ou en tant que sous-classe fournissent des informations et des discussions sur l'éducation d'une personne, qu'elle soit formelle ou informelle.</para>
    ///   <para>rdfs:label : education contextrdfs:label : contexte éducatif</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EducationContext">cwrc:EducationContext</a>
    /// </summary>
    let EducationContext = _prefixId.prefix "EducationContext"
    /// <summary>
    ///   <para>skos:definition : An award, financial, material, or immaterial, associated with a person's education at any level.skos:definition : </para>
    ///   <para>rdfs:label : récompenses scolairesrdfs:label : educational award</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalAward">cwrc:EducationalAward</a>
    /// </summary>
    let EducationalAward = _prefixId.prefix "EducationalAward"
    /// <summary>
    ///   <para>rdfs:label : établissement éducatifrdfs:label : educational organization</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>skos:definition : An organization such as a school that provides education, usually although not always as its primary function. "A school is an institution designed to provide learning spaces and learning environments for the teaching of students (or "pupils") under the direction of teachers." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «Une école est un établissement où l'on accueille des individus appelés « écoliers » afin que des professeurs leur dispensent un enseignement de façon collective.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalOrganization">cwrc:EducationalOrganization</a>
    /// </summary>
    let EducationalOrganization = _prefixId.prefix "EducationalOrganization"
    /// <summary>
    ///   <para>skos:definition : A medal or award, monetary or otherwise, presented by either an institution or person of authority to an individual who has excelled in some aspect of their education.skos:definition : </para>
    ///   <para>rdfs:label : educational prizerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalPrize">cwrc:EducationalPrize</a>
    /// </summary>
    let EducationalPrize = _prefixId.prefix "EducationalPrize"
    /// <summary>
    ///   <para>skos:definition : A subject or field of study or practice. Educational subjects are typically designated by Library of Congress Subject Headings (http://id.loc.gov/authorities/subjects.html). However, given the omissions, biases, and US-centricity of this vocabulary, other terms or strings may be used.skos:definition : </para>
    ///   <para>rdfs:label : educational subjectrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalSubject">cwrc:EducationalSubject</a>
    /// </summary>
    let EducationalSubject = _prefixId.prefix "EducationalSubject"
    /// <summary>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <para>rdfs:label : educational textrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EducationalText">cwrc:EducationalText</a>
    /// </summary>
    let EducationalText = _prefixId.prefix "EducationalText"
    let EnglishLanguage = _prefixId.prefix "EnglishLanguage"
    let EnglishNationalHeritage = _prefixId.prefix "EnglishNationalHeritage"
    let EnglishNationalIdentity = _prefixId.prefix "EnglishNationalIdentity"
    /// <summary>
    ///   <para>skos:definition : An award given in an educational context on the strength of the recipient's essay.skos:definition : </para>
    ///   <para>rdfs:label : essay awardrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#EssayAward">cwrc:EssayAward</a>
    /// </summary>
    let EssayAward = _prefixId.prefix "EssayAward"
    /// <summary>
    ///   <para>skos:definition :
    ///       Cette sous-classe de Forme Culturelle indique l'ethnicité d'une personne en parallèle avec le contexte fourni par les annotations de &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; lorsqu'il est présent. Une sous-classe de Forme Culturelle, elle indique l'ethnicité d'une personne, que celle-ci soit autodéclarée ou assignée par d'autres. Les ethnies sont des groupes qui se fondent sur une le partage de traditions ou d'héritages nationaux, religieux, géographiques, raciaux ou culturels; en fonction du contexte, certaines ethnies particulières sont dénigrées, glorifiées, ou les deux à la fois. Les ethnicités changeantes, historiquement constituées, développées de façon intéressée, et dont l'usage doit être resitué en contexte, sont enfin comprises ici comme discursives et représentationnelles, même si leurs répercussions matérielles sont bien réelles. Angel Oquendo écrit que «En dépit de son long passé ‘matérialiste' au cours duquel il était synonyme de ‘race', le concept d'ethnicité tel qu'il est employé aujourd'hui semble être centré sur la culture plutôt que sur la différence physionomique.» (Angel R. Oquendo, «Re-imagining the Latino/a Race» in The Latino/a Condition: A Critical Reader édité par Richard Delgado, Jean Stefancic) Cette ontologie ne prétend donc pas offrir un ensemble de catégories ethniques exact, complètement défini, ou mutuellement exclusif; cela est impossible étant donné leur utilisation en changement constant et leur chevauchement mutuel ou avec d'autres catégories identitaires utilisées pour la race, la géographie ou la nationalité. Les personnes qui utilisent cette classe et ses instances sont encouragées à consulter les annotations de &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; lorsqu'ils sont disponibles.
    ///     skos:definition :
    ///       A subclass of Cultural Form for indicating a person's ethnicity, either as self-reported or as assigned by others, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. Ethnicities are groups constructed on the conception of shared national, religious, geographical, racial, or cultural backgrounds or traditions, and particular ethnicities may be denigrated, lauded, or both, depending on the context. Ethnicities are shifting, historically constituted, and interestedly deployed categories whose use must be situated contextually and which are understood here finally as discursive or representational although they have real material impacts. As Angel Oquendo writes, "Despite its long ‘materialist' past in which it was taken to be synonymous with ‘race,' the concept of ethnicity as used today does appear to focus on cultural rather than on physiognomic difference." (Angel R. Oquendo, "Re-imagining the Latino/a Race" in The Latino/a Condition: A Critical Reader edited by Richard Delgado, Jean Stefancic &lt;a href="#cwrc:65424c4e-5257-4e6c-962f-de12a7f11aea"&gt;1998&lt;/a&gt;). This ontology therefore does not attempt to lay out an exact, fully defined, or mutually exclusive set of ethnic categories: this is an impossibility given their shifting use and the overlap among them and with identity categories for race, geography, and nationality, as demonstrated by Noel Ignatieve in his book How the Irish Became White &lt;a href="#cwrc:4f4d7ca6-5625-46d9-bd88-17847ee076d8"&gt;(Ignatieve, 1995)&lt;/a&gt;. Those using this class and its instances are encouraged to consult associated &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations, if available.
    ///     </para>
    ///   <para>rdfs:label : ethnicitérdfs:label : ethnicity</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Ethnicity">cwrc:Ethnicity</a>
    /// </summary>
    let Ethnicity = _prefixId.prefix "Ethnicity"
    let EthnicityContext = _prefixId.prefix "EthnicityContext"
    /// <summary>
    ///   <para>skos:definition : An event that occurs in time.skos:definition : </para>
    ///   <para>rdfs:label : évènementrdfs:label : eventrdfs:label : event</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Event">cwrc:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let EventElement = _prefixId.prefix "EventElement"
    /// <summary>
    ///   <para>skos:definition : An exhibition is a type of scholarship award or bursary.skos:definition : </para>
    ///   <para>rdfs:label : exhibition (scholarship)rdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Exhibition">cwrc:Exhibition</a>
    /// </summary>
    let Exhibition = _prefixId.prefix "Exhibition"
    /// <summary>
    ///   <para>skos:definition : A version of a name used by those familiar with a person, such as family, friends, or co-workers.skos:definition : </para>
    ///   <para>rdfs:label : familiar namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#FamiliarName">cwrc:FamiliarName</a>
    /// </summary>
    let FamiliarName = _prefixId.prefix "FamiliarName"
    /// <summary>
    ///   <para>skos:definition : Family Context is a significant subclass of context. Annotations typed as Family Context provide information about and discussions of a person's familial relations.  Family relationships are social bonds assumed between a group of people affiliated by blood, marriage, co-residence, or other affiliation. For more information, see &lt;a href="http://dbpedia.org/page/Family" title="http://dbpedia.org/page/Family"&gt;About: Family&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : family context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#FamilyContext">cwrc:FamilyContext</a>
    /// </summary>
    let FamilyContext = _prefixId.prefix "FamilyContext"
    /// <summary>
    ///   <para>skos:definition : An educational award or academic position usually associated with research or advanced standing in a field and sometimes involving labour such as teaching.skos:definition : </para>
    ///   <para>rdfs:label : fellowshiprdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Fellowship">cwrc:Fellowship</a>
    /// </summary>
    let Fellowship = _prefixId.prefix "Fellowship"
    let FemaleLabel = _prefixId.prefix "FemaleLabel"
    /// <summary>
    ///   <para>skos:definition : Définie de façon large, personne figurant dans une œuvre créative telle qu'une œuvre littéraire, dans laquelle elle est un personnage ou représentée d'une façon qui diffère de la personne physique à laquelle elle renvoie. Autrement dit, il existe une différence entre la simple allusion à une &lt;a href="#NaturalPerson" title="#NaturalPerson"&gt;personne physique&lt;/a&gt; et la version romancée de cette personne dans un texte ou tout autre oeuvre d'art. skos:definition : A person, broadly defined, who features in an imaginative work such as a literary work, as a character or in some other way that distinguishes the reference to them from the natural person who is being represented. In other words, there is a distinction between a simple allusion to a &lt;a href="#NaturalPerson" title="#NaturalPerson"&gt;natural person&lt;/a&gt;, and the fictionalization of that person within a text or other work of art.</para>
    ///   <para>rdfs:label : personne fictiverdfs:label : fictional person</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#FictionalPerson">cwrc:FictionalPerson</a>
    /// </summary>
    let FictionalPerson = _prefixId.prefix "FictionalPerson"
    /// <summary>
    ///   <para>skos:definition : A subject's given or baptismal name. This term is derived from the Text Encoding Initiative P5 schema 'forename' element. See also &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-forename.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-forename.html"&gt;TEI element forename &lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : forenamerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Forename">cwrc:Forename</a>
    /// </summary>
    let Forename = _prefixId.prefix "Forename"
    let FrenchLanguage = _prefixId.prefix "FrenchLanguage"
    /// <summary>
    ///   <para>skos:definition : Friends and connections context is a significant subclass of context. Annotations typed as friends and connections contexts discuss a broad spectrum of social relations ranging from friendship to enmities and casual associations. Other context annotations treat related aspects of social connections, including &lt;a href="#LeisureContext" title="#LeisureContext"&gt;leisure context&lt;/a&gt; and &lt;a href="#IntimateRelationshipsContext" title="#IntimateRelationshipsContext"&gt;intimate relationships context&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : friends and associates context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#FriendsAndAssociatesContext">cwrc:FriendsAndAssociatesContext</a>
    /// </summary>
    let FriendsAndAssociatesContext = _prefixId.prefix "FriendsAndAssociatesContext"
    /// <summary>
    ///   <para>skos:definition :
    ///       Cette sous-classe de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt; indique le genre d'une personne, qu'il soit attribué par d'autres ou autoproclamé, accompagné du contexte fourni par les annotations de &lt;a href="#GenderContext" title="#GenderContext"&gt;genre en contexte&lt;/a&gt; lorsque celui-ci est disponible.
    ///       Même si dans la culture populaire le genre et le sexe biologique sont confondus et compris comme binaires, le concept de genre souligne la dimension relationnelle, construite et performative des identités et des comportements genrés, dont les catégories sont contingentes et changent au cours de l'Histoire, sans qu'elles soient clairement délimitées. Cf
    ///       &lt;a href="#cwrc:c6a678e5-8fc6-41bc-8631-7cfb7116017e"&gt; Simone de Beauvoir &lt;/a&gt;: «On ne naît pas femme, on le devient,» et d'autres nombreuses théoriciennes du genre, dont Judith Butler en 1990
    ///       &lt;a href="#cwrc:825995b3-3b66-4e0a-a62d-d8649aaead78"&gt;(Judith Butler, 1990)&lt;/a&gt;. À ce jour, les études de genres se sont davantage intéressées à la construction de la féminité qu'à celle de la masculinité. Cette construction du genre à plusieurs niveaux est également soulignée par Donna Haraway qui le définit comme une «différence socialement, historiquement et sémiotiquement située»
    ///       &lt;a href="#cwrc:f62e94d6-bd04-494c-9282-53af0a3f3376"&gt;(Donna Haraway,1988)&lt;/a&gt;.
    ///       Le genre est interprété comme fluide, situationnel, parfois pluriel ainsi que lié à l'identité et l'orientation sexuelles sans leur être proportionnel, tout comme il est relié à certaines façons spécifiques de vivre et de présenter son corps, qui ne définissent pas non plus le genre. Plutôt que de voir le sexe biologique comme présocial ou un fait naturel, le corps est compris comme un lieu d'inscriptions (cf. &lt;a href="#cwrc:3d49dc32-ac97-4abd-a252-573c52b463cf"&gt; (Elizabeth Grosz, 1994)&lt;/a&gt;) qui est aussi socialement construit et épigénétiquement modelé par des facteurs environnementaux &lt;a href="#cwrc:5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249"&gt;(N. Katherine Hayles, 2012)&lt;/a&gt;. Selon la formulation de la neurologiste féministe Gillian Einstein, «Le monde écrit sur le corps» &lt;a href="#cwrc:842ffbb4-11de-4212-8e6e-9d4d8d28d3a5"&gt;(Gillian Einstein, 2012)&lt;/a&gt;. Cette ontologie ne fournit donc pas de termes séparés pour le sexe et le genre en tant qu'entités distinctes. Au contraire, elle privilégie les termes associés au genre, en admettant qu'ils sont conventionnellement mais non nécessairement associés au sexe, et qu'il existe un glissement constant de ces catégories au fil des discours, des actions et des institutions. Loin d'indiquer une part d'expérience universelle, le genre rencontre d'autres catégories identitaires et divers vecteurs d'oppression comme la classe, la race, la couleur ou l'héritage géographique, produisant des expériences et des intérêts très différents pour les personnes d'un même genre. Un exemple est le mouvement de la Chrétienté Musculaire, formé au Royaume-Uni au 19ème siècle, qui relie la religion à l'identité masculine. Une telle interaction entre différentes formes d'oppression est appelée «intersectionnalité» &lt;a href="#cwrc:b9eeccf9-9380-4341-99dc-a83f5ee32909"&gt;(Kimberlé Crenshaw, 1989)&lt;/a&gt;.
    ///       Les personnes qui utilisent cette classe et ses instances sont encouragées à consulter les annotations associées fournies par &lt;a href="#GenderContext" title="#GenderContext"&gt;genre en contexte&lt;/a&gt;, si disponibles.
    ///     skos:definition :
    ///       A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; for indicating a person's gender, whether attributed or self-reported, with accompanying context, where present, provided by &lt;a href="#GenderContext" title="#GenderContext"&gt;gender context&lt;/a&gt; annotations.
    ///       Although in popular culture gender and biological sex are conflated and understood to be binary, the concept of gender stresses the relationality, constructedness, and performativity of gendered identities and gendered behaviour, whose categories are historically contingent and shifting, and the boundaries between them blurry. Simone de Beauvoir &lt;a href="#cwrc:c6a678e5-8fc6-41bc-8631-7cfb7116017e"&gt; (1973) &lt;/a&gt; stated "One is not born, but rather becomes, a woman," a belief that has been taken up by many other theorists of gender including Judith Butler &lt;a href="#cwrc:825995b3-3b66-4e0a-a62d-d8649aaead78"&gt;(1990)&lt;/a&gt;. Gender studies to date has investigated the social construction of femininity more than that of masculinity. The multi-layered constructedness of gender is also underlined by Donna Haraway who understands it as a "socially, historically, and semiotically positioned difference" &lt;a href="#cwrc:f62e94d6-bd04-494c-9282-53af0a3f3376"&gt;(Donna Haraway, 1988)&lt;/a&gt;.
    ///       Gender is understood as fluid, situational, and sometimes plural, and it is related to, though not commensurate with, sexual identity and orientation, just as it is related to but not defined by specific forms of embodiment. Rather than seeing biological sex as a pre-social or natural given, the body is understood as a site of inscription (cf. &lt;a href="#cwrc:3d49dc32-ac97-4abd-a252-573c52b463cf"&gt; (Elizabeth Grosz, 1994)&lt;/a&gt;) which is also socially constructed and indeed epigenetically shaped by environmental factors &lt;a href="#cwrc:5e45242f-0c2e-4aaa-8ddb-ac54dd0e6249"&gt;(N. Katherine Hayles, 2012)&lt;/a&gt;. As articulated by feminist neurologist Gillian Einstein, &lt;a href="#cwrc:842ffbb4-11de-4212-8e6e-9d4d8d28d3a5"&gt;(2012)&lt;/a&gt;"The world writes on the body." This ontology therefore does not provide separate terms for sex as distinct from gender. Instead, it privileges terms associated with gender, recognizing that they are conventionally but not necessarily associated with sex, and that there is constant slippage between gender and sex in the way that these categories circulate through discourses, actions, and institutions. Far from indicating a universal facet of experience, gender intersects with other identity categories and axes of oppression such as class, race or colour, or geographical heritage to produced quite different interests and experiences among people of the same gender, as with the intersection of religion and white masculine identity in the Muscular Christianity movement in nineteenth-century Britain. Being a woman of colour often compounds the impacts of gender oppression. Such interaction between different forms of oppression is termed "intersectionality" &lt;a href="#cwrc:b9eeccf9-9380-4341-99dc-a83f5ee32909"&gt;(Kimberlé Crenshaw, 1989).&lt;/a&gt;
    ///       Those using this class and its instances are encouraged to consult associated &lt;a href="#GenderContext" title="#GenderContext"&gt;gender context&lt;/a&gt; annotations, if available.
    ///     </para>
    ///   <para>rdfs:label : genrerdfs:label : gender</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Gender">cwrc:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>rdfs:label : genre en contexterdfs:label : gender context</para>
    ///   <para>skos:definition : Gender Context is a significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. It is associated with the &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; subclass &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt;, and sometimes other intersecting Cultural Forms. Annotations typed as Gender Context provide information about and discussions of a person's subjectivity with regards to their gender and gender identity. Gender Context provides depth to more granular categorizations of a person indicated through the properties &lt;a href="#hasGender" title="#hasGender"&gt;has gender identity&lt;/a&gt; or &lt;a href="#hasGenderSelfReported" title="#hasGenderSelfReported"&gt;has gender identity (self-reported)&lt;/a&gt;.skos:definition : Genre En Contexte est une sous-classe de contexte importante. Elle est associée à la sous-classe de Forme Culturelle &lt;a href="#Gender" title="#Gender"&gt;genre&lt;/a&gt;, et se recoupe parfois avec d'autres Formes Culturelles. Les annotations entrées en tant que Genre En Contexte fournissent des renseignements et des discussions sur la subjectivité d'une personne en ce qui concerne son genre et son identité genrée. Genre Contexte explore plus en détails les indications granulaires des propriétés &lt;a href="#hasGender" title="#hasGender"&gt;est de genre&lt;/a&gt; ou &lt;a href="#hasGenderSelfReported" title="#hasGenderSelfReported"&gt;est de genre (autodéclaré)&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#GenderContext">cwrc:GenderContext</a>
    /// </summary>
    let GenderContext = _prefixId.prefix "GenderContext"
    let GenderQueer = _prefixId.prefix "GenderQueer"
    /// <summary>
    ///   <para>skos:definition : A name component used to distinguish otherwise similar names on the basis of the relative ages or generations of the persons named." This term is derived from the Text Encoding Initiative P5 schema for the 'genName' element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-genName.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-genName.html"&gt;TEI element genName  (generational name component) &lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : generational namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#GenerationalName">cwrc:GenerationalName</a>
    /// </summary>
    let GenerationalName = _prefixId.prefix "GenerationalName"
    /// <summary>
    ///   <para>skos:definition : Une sous-classe de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;, Héritage Géographique indique l'héritage géographique d'une personne, accompagné du contexte fourni par &lt;a href="#NationalityContext" title="#NationalityContext"&gt;contexte national&lt;/a&gt; lorsqu'il est disponible. L'héritage géographique inclut les origines géographiques de la famille du sujet, souvent utiles à la compréhension de son milieu ethnique et raciale. Cela permet par exemple de saisir l'identité des femmes qui se déclarent «sud-asiatiques», alors que nous n'en savons pas plus sur leur héritage national. Voir &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; pour un compte-rendu détaillé de la complexité de cette classe. L'héritage géographique peut être pluriel et peut différer de l'identité ou de l'héritage national, de la citoyenneté actuelle ou officielle, et de la région géographique ou du lieu de résidence. Les personnes qui utilisent cette classe et ses instances sont encouragées à consulter les extraits ou les annotations de &lt;a href="#NationalityContext" title="#NationalityContext"&gt;contexte national&lt;/a&gt; lorsqu'ils sont disponibles.skos:definition : A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;, this property indicates a person's geographic heritage, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. Geographic heritage involves the geographical origins of a person's family, which often contributes to an understanding of their racial and ethnic background. It offers a way to capture individuals identified as "South-Asian," for example, when no more precise national heritage is indicated. See &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; for a detailed description of the complexities of this class. It can be multiple and it can be different from a person's national identity or national heritage, current or official citizenship, or the geographical region or territory in which a person resides. Those using this class and its instances are encouraged to consult associated &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; excerpts or annotations, if available.</para>
    ///   <para>skos:note : Les termes &lt;a href="http://geonames.org/"&gt;Geonames&lt;/a&gt; sont souvent utilisés pour les lieux et de nombreuses instances &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;héritage géographique&lt;/a&gt;.skos:note : &lt;a href="http://geonames.org/"&gt;Geonames&lt;/a&gt; terms are often used for locations and for many instances of &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;.</para>
    ///   <para>rdfs:label : héritage géographiquerdfs:label : geographic heritage</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#GeographicHeritage">cwrc:GeographicHeritage</a>
    /// </summary>
    let GeographicHeritage = _prefixId.prefix "GeographicHeritage"
    let GeographicalHeritage = _prefixId.prefix "GeographicalHeritage"
    /// <summary>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>skos:definition : "A grammar school is one of several different types of school in the history of education in the United Kingdom and other English-speaking countries, originally a school teaching Latin, but more recently an academically-oriented secondary school, differentiated in recent years from less academic Secondary Modern Schools." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «Une grammar school est, dans les pays anglophones, un établissement d'enseignement secondaire ou, plus rarement, d'enseignement primaire. Les origines des grammar schools remontent à l'Europe médiévale.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:label : grammar schoolrdfs:label : grammar school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#GrammarSchool">cwrc:GrammarSchool</a>
    /// </summary>
    let GrammarSchool = _prefixId.prefix "GrammarSchool"
    let GurjapSingh = _prefixId.prefix "GurjapSingh"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as health provide information about and discussions of a person's health, both mental and physical, and associated social, political and historical factors.skos:definition : </para>
    ///   <para>rdfs:label : health contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#HealthContext">cwrc:HealthContext</a>
    /// </summary>
    let HealthContext = _prefixId.prefix "HealthContext"
    /// <summary>
    ///   <para>skos:definition : Indicates a very high level of significance appropriate to a historical overview.skos:definition : </para>
    ///   <para>rdfs:label : historic significancerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#HistoricSignificance">cwrc:HistoricSignificance</a>
    /// </summary>
    let HistoricSignificance = _prefixId.prefix "HistoricSignificance"
    /// <summary>
    ///   <para>skos:definition : A positive name which celebrates or honours a person. skos:definition : </para>
    ///   <para>rdfs:label : honorific namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#HonorificName">cwrc:HonorificName</a>
    /// </summary>
    let HonorificName = _prefixId.prefix "HonorificName"
    /// <summary>
    ///   <para>skos:definition : Name under which a person's work is indexed by an institution or organization.skos:definition : </para>
    ///   <para>rdfs:label : indexed namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#IndexedName">cwrc:IndexedName</a>
    /// </summary>
    let IndexedName = _prefixId.prefix "IndexedName"
    /// <summary>
    ///   <para>skos:definition : Indicates a level of significance appropriate to an understanding of an individual person or entity.skos:definition : </para>
    ///   <para>rdfs:label : individual significancerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#IndividualSignificance">cwrc:IndividualSignificance</a>
    /// </summary>
    let IndividualSignificance = _prefixId.prefix "IndividualSignificance"
    /// <summary>
    ///   <para>skos:definition : L'instruction ou l'apprentissage a lieu dans un cadre institutionnel.skos:definition : Context for education or learning within an institutional setting.</para>
    ///   <para>rdfs:label : institutional education contextrdfs:label : contexte éducatif institutionnel</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#InstitutionalEducationContext">cwrc:InstitutionalEducationContext</a>
    /// </summary>
    let InstitutionalEducationContext = _prefixId.prefix "InstitutionalEducationContext"
    let IntervalTime = _prefixId.prefix "IntervalTime"
    /// <summary>
    ///   <para>skos:definition : Intimate relationships context is a significant subclass of context. Annotations typed intimate relationships discuss any type of intimacy ranging from emotional through psychological or material to sexual.skos:definition : </para>
    ///   <para>rdfs:label : intimate relationships context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#IntimateRelationshipsContext">cwrc:IntimateRelationshipsContext</a>
    /// </summary>
    let IntimateRelationshipsContext = _prefixId.prefix "IntimateRelationshipsContext"
    let JadePenancier = _prefixId.prefix "JadePenancier"
    let JasmineDrudgeWillson = _prefixId.prefix "JasmineDrudgeWillson"
    let JewishEthnicity = _prefixId.prefix "JewishEthnicity"
    let JoelCummings = _prefixId.prefix "JoelCummings"
    let JohnSimpson = _prefixId.prefix "JohnSimpson"
    let KimMartin = _prefixId.prefix "KimMartin"
    /// <summary>
    ///   <para>skos:definition : A human language or dialect, whether spoken and/or written.skos:definition : Une langue ou un dialecte humain, à l'oral et/ou à l'écrit.</para>
    ///   <para>rdfs:label : languagerdfs:label : langue</para>
    ///   <para>skos:note :  &lt;a href="http://id.loc.gov/vocabulary/languages.html"&gt;Library of Congress Languages&lt;/a&gt; codes are typically used for instances of &lt;i&gt;language&lt;/i&gt; .skos:note :  Les codes de la &lt;a href="http://id.loc.gov/vocabulary/languages.html"&gt;Bibliothèque du congrès&lt;/a&gt; sont normalement utilisés pour les instances de &lt;i&gt;language&lt;/i&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Language">cwrc:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    let LanguageContext = _prefixId.prefix "LanguageContext"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Leisure Context provide information about and discussions of instances of the leisure and social activities of a person including hobbies, sporting life and cultural activities, for example mountain climbing or hosting a literary salon.  Notions of leisure are both gendered and classed, and vary by cultural context. This context is meant to capture a person's social life within their larger community, not simply an elite, fashionable social circle.skos:definition : </para>
    ///   <para>rdfs:label : leisure contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#LeisureContext">cwrc:LeisureContext</a>
    /// </summary>
    let LeisureContext = _prefixId.prefix "LeisureContext"
    let LinguisticAbility = _prefixId.prefix "LinguisticAbility"
    /// <summary>
    ///   <para>skos:definition : An event associated with the climate for literature and writing, broadly conceived, ranging from publication or performance events to information about print technologies and copyright.skos:definition : </para>
    ///   <para>rdfs:label : literary climaterdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#LiteraryClimate">cwrc:LiteraryClimate</a>
    /// </summary>
    let LiteraryClimate = _prefixId.prefix "LiteraryClimate"
    /// <summary>
    ///   <para>skos:definition : A name applied to a writer by others, for example in reviews or at readings, which orginate in the person's status as a writer.skos:definition : </para>
    ///   <para>rdfs:label : literary namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#LiteraryName">cwrc:LiteraryName</a>
    /// </summary>
    let LiteraryName = _prefixId.prefix "LiteraryName"
    /// <summary>
    ///   <para>skos:definition : A name with a geographic connotation, for example, "Julian of Norwich."skos:definition : </para>
    ///   <para>rdfs:label : local namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#LocalName">cwrc:LocalName</a>
    /// </summary>
    let LocalName = _prefixId.prefix "LocalName"
    /// <summary>
    ///   <para>skos:definition : A surname adopted in marriage. skos:definition : </para>
    ///   <para>rdfs:label : married namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#MarriedName">cwrc:MarriedName</a>
    /// </summary>
    let MarriedName = _prefixId.prefix "MarriedName"
    /// <summary>
    ///   <para>skos:definition : A subclass of &lt;a href="#HealthContext" title="#HealthContext"&gt;health context&lt;/a&gt;. Annotations typed as mental health context describe an aspect of a person’s mental or psychological well-being or illness.skos:definition : </para>
    ///   <para>rdfs:label : mental health contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#MentalHealthContext">cwrc:MentalHealthContext</a>
    /// </summary>
    let MentalHealthContext = _prefixId.prefix "MentalHealthContext"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as name context provide the name or names associated with a person, at times with contextual information.skos:definition : </para>
    ///   <para>rdfs:label : name contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NameContext">cwrc:NameContext</a>
    /// </summary>
    let NameContext = _prefixId.prefix "NameContext"
    /// <summary>
    ///   <para>skos:definition : "A connecting phrase or link used within a name but not regarded as part of it, such as van der or of." This term is derived from the Text Encoding Initiative P5 schema for the 'NameLink' element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-nameLink.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-nameLink.html"&gt;TEI element nameLink  (name link) &lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : name linkrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NameLink">cwrc:NameLink</a>
    /// </summary>
    let NameLink = _prefixId.prefix "NameLink"
    /// <summary>
    ///   <para>skos:definition : An aspect of a person's name, including its use, connotations, or significance. skos:definition : </para>
    ///   <para>rdfs:label : name typerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NameType">cwrc:NameType</a>
    /// </summary>
    let NameType = _prefixId.prefix "NameType"
    /// <summary>
    ///   <para>skos:definition : Une sous-catégorie de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;, cette propriété indique l'héritage national d'une personne, accompagné du &lt;a href="#NationalityContext" title="#NationalityContext"&gt;contexte national&lt;/a&gt; lorsqu'il est disponible. Héritage National est composé de divers éléments relatifs à l'identité nationale, et est souvent transmis par des générations antérieures, influencé par le milieu historique et l'héritage géographique. Il peut être puluriel et peut se distinguer de l'identité nationale, de la citoyenneté actuelle ou officielle, de la région géographique ou du territoire de résidence. Les personnes qui utilisent cette classe et ses instances sont encouragées à consulter les extraits ou les annotations de &lt;a href="#NationalityContext" title="#NationalityContext"&gt;contexte national&lt;/a&gt; lorsque ceux-ci sont disponibles.skos:definition : A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;, this property indicates a person's national heritage, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. National Heritage is composed of various elements related to national identity, often transmitted from previous generations and influenced by a subject's national historical background or &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;. It can be multiple and can be different from a person's national identity, current or official citizenship, or the geographical region or territory in which a person resides. Those using this class and its instances are encouraged to consult associated &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; excerpts or annotations, if available.</para>
    ///   <para>rdfs:label : national heritagerdfs:label : héritage national</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NationalHeritage">cwrc:NationalHeritage</a>
    /// </summary>
    let NationalHeritage = _prefixId.prefix "NationalHeritage"
    /// <summary>
    ///   <para>skos:definition : Une sous-catégorie de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;, cette propriété indique la nationalité d'une personne, qu'elle soit autodéclarée ou attribuée par d'autres, accompagnée du contexte fourni par les annotations de &lt;a href="#NationalityContext" title="#NationalityContext"&gt;contexte national&lt;/a&gt; lorsqu'il est disponible. Elle diffère de la citoyenneté et n'est pas proportionnelle à la zone géographique ou au territoire de la personne, même si elle est généralement liée au pays ou à la zone géographique actuelle ou passée. Pour cette raison, (vois &lt;a href="https://fr.wikipedia.org/wiki/ISO_3166-2"&gt;les codes de la norme ISO 2 pour la représentation des pays et de leurs subdivisions-Partie 2 : Codes des subdivisions des pays&lt;/a&gt;) sont utilisés dans la mesure du possible pour représenter les instances de nationalités, et seuls les termes pour lesquels aucun code pays n'existe apparaissent dans l'ontologie. Comme d'autres catégories identitaires, la nationalité peut être plurielle, fluide ou contingente, et recoupe avec &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;héritage national&lt;/a&gt; ainsi qu'avec d'autres catégories identitaires. Les personnes qui utilisent cette classe et ses instances sont encouragées à consulter les annotations de &lt;a href="#NationalityContext" title="#NationalityContext"&gt;contexte national&lt;/a&gt; lorsqu'elles sont disponibles.skos:definition : A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;, this property indicates a person's national identity, either as self-reported or as assigned by others, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. It is neither the same as citizenship nor commensurate with the geographical region or territory in which a person resides, although it is usually associated with a current or former country or geographic region. For this reason, the (see &lt;a href="https://en.wikipedia.org/wiki/ISO_3166-2"&gt;ISO 2-digit Codes for the representation of names of countries and their subdivisions – Part 2: Country subdivision codes&lt;/a&gt;) are used where possible to represent instances of national identities, and only terms for which country codes do not exist appear in this ontology. Like other identity categories, nationality may be plural, fluid, or contingent, and terms used for national identities can intersect with &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;national heritage&lt;/a&gt;, &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;, and &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt; as well as other identity categories. Those using this class and its instances are encouraged to consult associated &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations, if available.</para>
    ///   <para>rdfs:label : national identityrdfs:label : identité nationale</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NationalIdentity">cwrc:NationalIdentity</a>
    /// </summary>
    let NationalIdentity = _prefixId.prefix "NationalIdentity"
    /// <summary>
    ///   <para>rdfs:label : contexte nationalrdfs:label : nationality context</para>
    ///   <para>skos:definition : Contexte National est une sous-classe de contexte importante. Les annotations entrées en tant que Contexte National fournissent des informations et des discussions sur la formation culturelle d'une personne, en lien avec son identité nationale, son héritage national et son héritage géographique qui ne sont pas toujours équivalents. Contexte National explore plus en détails les indications granulaires sur l'identité nationale à travers les propriétés &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;héritage national&lt;/a&gt;, &lt;a href="#NationalIdentity" title="#NationalIdentity"&gt;identité nationale&lt;/a&gt; et &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;héritage géographique&lt;/a&gt;.skos:definition : Nationality Context is a significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Nationality Context provide information about and discussions of a person's cultural formation in relation to their national identity, national heritage, and geographic heritage -- which are not always aligned. Nationality Context provides depth to more granular indications of national identity through the &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;national heritage&lt;/a&gt;, &lt;a href="#NationalIdentity" title="#NationalIdentity"&gt;national identity&lt;/a&gt;, and &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt; properties.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NationalityContext">cwrc:NationalityContext</a>
    /// </summary>
    let NationalityContext = _prefixId.prefix "NationalityContext"
    /// <summary>
    ///   <para>skos:definition : A human being who is alive, or was alive at some point in time. Natural persons may be fictionalized, in which case they are also classed as a &lt;a href="#FictionalPerson" title="#FictionalPerson"&gt;fictional person&lt;/a&gt;.skos:definition :  Être humain en vie ou ayant vécu à un moment donné. Les personnes physiques peuvent être objets de fiction, auquel cas elles sont classées en tant que &lt;a href="#FictionalPerson" title="#FictionalPerson"&gt;personne fictive&lt;/a&gt;.</para>
    ///   <para>rdfs:label : personne physiquerdfs:label : natural person</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#NaturalPerson">cwrc:NaturalPerson</a>
    /// </summary>
    let NaturalPerson = _prefixId.prefix "NaturalPerson"
    /// <summary>
    ///   <para>skos:definition : Indicates familiar, humorous, or abusive name given to a person, applied instead of or in addition to their real name. May have &lt;a href="#NameType" title="#NameType"&gt;name type&lt;/a&gt;, &lt;a href="#AbusiveName" title="#AbusiveName"&gt;abusive name&lt;/a&gt; or &lt;a href="#HonorificName" title="#HonorificName"&gt;honorific name&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : nicknamerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Nickname">cwrc:Nickname</a>
    /// </summary>
    let Nickname = _prefixId.prefix "Nickname"
    /// <summary>
    ///   <para>skos:definition : A position, activity, job, or profession, whether paid, unpaid, or voluntary, often related to and at times overlapping with a person's &lt;a href="#SocialClass" title="#SocialClass"&gt;social class&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : occupationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Occupation">cwrc:Occupation</a>
    /// </summary>
    let Occupation = _prefixId.prefix "Occupation"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as occupation provide information about and discussions of positions and activities significant to a person's life, including paid, unpaid, and voluntary work both beyond and within the home. Although writing as a career sometimes overlaps with occupation, literary activities are often described in writing contexts.skos:definition : </para>
    ///   <para>rdfs:label : occupation contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#OccupationContext">cwrc:OccupationContext</a>
    /// </summary>
    let OccupationContext = _prefixId.prefix "OccupationContext"
    /// <summary>
    ///   <para>skos:definition : Indicates the  works of an author or other creative practioner regarded collectively.skos:definition : </para>
    ///   <para>rdfs:label : oeuvrerdfs:label : oeuvre</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Oeuvre">cwrc:Oeuvre</a>
    /// </summary>
    let Oeuvre = _prefixId.prefix "Oeuvre"
    let Organization = _prefixId.prefix "Organization"
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>skos:definition : Indicates a moderate level of significance appropriate to an understanding of a historical period.skos:definition : </para>
    ///   <para>rdfs:label : period significancerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PeriodSignificance">cwrc:PeriodSignificance</a>
    /// </summary>
    let PeriodSignificance = _prefixId.prefix "PeriodSignificance"
    /// <summary>
    ///   <para>skos:definition : Un persona, contrairement à un rôle, ne peut être incarné par quiconque, mais est spécifique à une personne physique, ou plus rarement à plusieurs d'entre elles. Un persona est une création originale, souvent inspiré par le contexte biographique, historique et sociologique auquel son/ses créateur·ice(s) est/sont attaché·e(s). Les personae tels qu'ils sont définis ici ne doivent pas être confondus avecune maladie mentale ou à un trouble dissociatif de l'identité, car ils ne relèvent pas d'une perception déformée ou incontrôlée de la réalité. Le persona est avant tout une entité identitaire capable d'interargir avec le monde extérieur et qui peut parfois être confondue avec une personne physique réelle. Il est incarné et développé par une personne physique, et peut avoir une activité sociale, littéraire, artistique ou politique.skos:definition : A persona, unlike a role, cannot be adopted by people generally, but is specific to one natural person, or more rarely several natural persons. A persona is an original creation, often bearing meaning regarding the biographical, historical and sociological context to which its/their creator/s is/are attached. Personas as defined here should not be associated with mental illness or multiple personality disorder, since they are not the product of a distorted or uncontrolled perception of reality. At the heart of a persona is an identity that is interacted with by others and that at times can be confused with an actual natural person. It is incarnated and developed by a natural person, and may have a social, literary, artistic or political activity.</para>
    ///   <para>rdfs:comment : This definition is indebted to the Text Encoding Initiative's definition of the "persona" element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persona.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persona.html"&gt;TEI element persona &lt;/a&gt;.</para>
    ///   <para>rdfs:label : rdfs:label : persona</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Persona">cwrc:Persona</a>
    /// </summary>
    let Persona = _prefixId.prefix "Persona"
    /// <summary>
    ///   <para>rdfs:label : personal namerdfs:label : </para>
    ///   <para>skos:definition : skos:definition : A person's name, containing a proper noun or proper-noun phrase referring to a person. Has subclasses for types of names such as &lt;a href="#Pseudonym" title="#Pseudonym"&gt;pseudonym&lt;/a&gt; and may have &lt;a href="#NameType" title="#NameType"&gt;name type&lt;/a&gt;, and may have associated parts. This term is derived in part from the Text Encoding Initiative P5 schema persname element. See also &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persName.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-persName.html"&gt;TEI element persName  (personal name) &lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PersonalName">cwrc:PersonalName</a>
    /// </summary>
    let PersonalName = _prefixId.prefix "PersonalName"
    /// <summary>
    ///   <para>skos:definition : A subclass of &lt;a href="#HealthContext" title="#HealthContext"&gt;health context&lt;/a&gt;. Annotations typed as physical health context describe aspects of a person’s bodily or physical well-being or illness.skos:definition : </para>
    ///   <para>rdfs:label : physical health contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PhysicalHealthContext">cwrc:PhysicalHealthContext</a>
    /// </summary>
    let PhysicalHealthContext = _prefixId.prefix "PhysicalHealthContext"
    /// <summary>
    ///   <para>skos:definition : It may be, but is not necessarily, a populated place. Some places, such as cross-roads, do not have a population or settlement per se. Geonames will sometimes categorize places that are now abandoned as "populated places."skos:definition : A named place, whether incorporated, settled, or occupied.skos:definition : Il peut concerner un endroit peuplé, mais pas nécessairemment. Certains endroits, comme les intersections, n'ont pas de de populations ou d'habitants en soi. Les Geonames classifieront parfois les endroits désormais abandonnés comme «lieux habités».skos:definition : Un endroit nommé, qu'il soit déclaré, peuplé ou occupé.</para>
    ///   <para>rdfs:label : placerdfs:label : endroit</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Place">cwrc:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>skos:definition : This subclass of CulturalForm indicates affiliations, connections and associations which designate a person's political involvement. These affiliations can be both formal connections to a party or organisation and informal political positions held by the writer. Political affiliations are defined broadly and include things like "against capital punishment" or "strong supporter of the Empire" in addition to more straightforward affiliations such as "marxist" or "conservative". Political affiliations can be multiple, sometimes contradictory, and may change over time.skos:definition : Cette sous-classe de forme culturelle indique les appartenances, les connexions et les associations qui font partie de l'engagement politique d'une personne. Elles renvoient aussi bien aux connexions formelles avec un parti ou une organisation qu'aux autres partis pris politiques informels de l'auteur·e. Les appartenances politiques sont définies au sens large et incluent des exemples comme « lutte contre la peine de mort » ou « fervent·e défenseur·se de l'Empire » en plus d'appartenance plus directes telles que « marxiste » ou « conservateur·ice ». Les appartenances politiques peuvent être multiple, parfois contradictoires ou en tension, et peuvent changer au cours du temps.</para>
    ///   <para>rdfs:label : political affiliationrdfs:label : appartenance politique</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalAffiliation">cwrc:PoliticalAffiliation</a>
    /// </summary>
    let PoliticalAffiliation = _prefixId.prefix "PoliticalAffiliation"
    /// <summary>
    ///   <para>skos:definition : An event having political implications within its geopolitical context, often nationally or internationally. Includes the accession of' monarchs, changing governing structures including revolutions, the establishment of major organizations, and other markers of political change.skos:definition : </para>
    ///   <para>rdfs:label : political climaterdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalClimate">cwrc:PoliticalClimate</a>
    /// </summary>
    let PoliticalClimate = _prefixId.prefix "PoliticalClimate"
    /// <summary>
    ///   <para>skos:definition : Contexte Politique est une sous-classe de &lt;a href="#Context" title="#Context"&gt;contexte&lt;/a&gt; importante. Elle est associée à &lt;a href="#PoliticalAffiliation" title="#PoliticalAffiliation"&gt;appartenance politique&lt;/a&gt;, sous-classe de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;, et recoupe parfois avec d'autres Formes Culturelles. Les annotations entrées en tant que Contexte Politique fournissent des informations et des discussions sur la subjectivité d'une personne en lien avec son activité politique. Contexte Politique explore plus en détails les catégories granulaires d'une personne grâce aux propriétés &lt;a href="#hasPoliticalAffiliation" title="#hasPoliticalAffiliation"&gt;a une appartenance politique&lt;/a&gt; ou &lt;a href="#hasPoliticalAffiliationSelfReported" title="#hasPoliticalAffiliationSelfReported"&gt;a une appartenance politique (autodéclarée)&lt;/a&gt;).skos:definition : Politics Context is a significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. It is associated with the &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; subclass &lt;a href="#PoliticalAffiliation" title="#PoliticalAffiliation"&gt;political affiliation&lt;/a&gt;, and sometimes other intersecting Cultural Forms. Annotations typed as Politics Context provide information about and discussions of a person's subjectivity with regards to their political identity. Politics Context provides depth to more granular categorizations of a person indicated by the properties &lt;a href="#hasPoliticalAffiliation" title="#hasPoliticalAffiliation"&gt;has political affiliation&lt;/a&gt; and its subproperties.</para>
    ///   <para>rdfs:label : contexte politiquerdfs:label : politics context</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalContext">cwrc:PoliticalContext</a>
    /// </summary>
    let PoliticalContext = _prefixId.prefix "PoliticalContext"
    /// <summary>
    ///   <para>skos:definition : An organization whose activities are primarily political or with which a person is affiliated politically.skos:definition : </para>
    ///   <para>rdfs:label : political organizationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PoliticalOrganization">cwrc:PoliticalOrganization</a>
    /// </summary>
    let PoliticalOrganization = _prefixId.prefix "PoliticalOrganization"
    /// <summary>
    ///   <para>skos:definition : «Le terme d'études supérieures désigne généralement l'éducation dispensée par les universités, les collèges anglo-saxons, avec en France un système plus dual de grandes écoles et d'autres institutions comme les grands établissements décernant des grades universitaires ou autres diplômes de l'enseignement supérieur. Ces études visent à acquérir un niveau "supérieur" de compétences, généralement via une inscription ou concours d'entrée, un cursus ponctués par des examens. Historiquement, il s'agissait autrefois d'abord de former les élites recrutées par les États, les armées et les religions, puis (à partir de la révolution industrielle) par les monde économique et industriel et de la culture ou de l'enseignement. Mais d'autres dimensions, socioculturelles et éthiques ou de développement durable sont apparues à la fin du XXe siècle, ajoutant une dimension de service public visant à permettre aux étudiants, de trouver leur voie ou domaine d'excellence, de se préparer aux métiers futurs tout en faisant progresser le savoir. Ces études se déroulent souvent autour de campus, dans un système public ou privé selon les cas, et souvent catégorisés en « Sciences dures », « sciences de l'ingénieur » et « sciences humaines et sociales ». Les types de diplômes évoluent avec le temps, mais tendent à s'homogénéiser aux niveaux européens et internationaux avec les licences, des masters, et des doctorats pour faciliter les systèmes d'équivalence ou de reconnaissance mutuelle de diplômes. Cette formation inclut des cours et des stages, et peut également comporter des participations à la recherche scientifique (notamment au niveau du doctorat) et intégrer de la formation continue, mais accepte souvent aussi des « auditeurs libres » qui viennent simplement accroître leur culture générale ou spécialisée.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : "Higher education, post-secondary education, or third level education is an optional final stage of formal learning that occurs after secondary education. Often delivered at universities, academies, colleges, seminaries, and institutes of technology, higher education is also available through certain college-level institutions, including vocational schools, trade schools, and other career colleges that award academic degrees or professional certifications. Tertiary education at non-degree level is sometimes referred to as further education or continuing education as distinct from higher education. The right of access to higher education is mentioned in a number of international human rights instruments. The UN International Covenant on Economic, Social and Cultural Rights of 1966 declares, in Article 13, that "higher education shall be made equally accessible to all, on the basis of capacity, by every appropriate means, and in particular by the progressive introduction of free education". In Europe, Article 2 of the First Protocol to the European Convention on Human Rights, adopted in 1950, obliges all signatory parties to guarantee the right to education" &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <para>rdfs:label : post-secondary schoolrdfs:label : post-secondary school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PostSecondarySchool">cwrc:PostSecondarySchool</a>
    /// </summary>
    let PostSecondarySchool = _prefixId.prefix "PostSecondarySchool"
    /// <summary>
    ///   <para>skos:definition : Indicates the form of name preferred by an authority or institution.skos:definition : </para>
    ///   <para>rdfs:label : preferred namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PreferredName">cwrc:PreferredName</a>
    /// </summary>
    let PreferredName = _prefixId.prefix "PreferredName"
    /// <summary>
    ///   <para>skos:definition : Within a North American context, prep schools are private educational institutions that prepare students for college. Within a British context, they are private schools for students -- the age range of the students can vary significantly depending on when they went to school, though typically ranging from ages seven (though sometimes three) to thirteen.skos:definition : Dans le contexte nord-américain, les écoles préparatoires sont des établissements d'enseignement privés qui préparent les étudiant·e·s à l'université. Dans le contexte britannique, ce sont des écoles privées pour les étudiants; la tranche d'âge des élèves peut varier considérablement en fonction du début de leur scolarisation, mais elle va généralement de sept (parfois trois) à treize ans.</para>
    ///   <para>rdfs:label : école préparatoirerdfs:label : prep school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PrepSchool">cwrc:PrepSchool</a>
    /// </summary>
    let PrepSchool = _prefixId.prefix "PrepSchool"
    /// <summary>
    ///   <para>rdfs:comment : La description de ce terme est basée sur celle de DBPedia.rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <para>skos:definition :  «L'enseignement primaire, ou l'école primaire, est, dans plusieurs pays, le premier degré de l'enseignement. Il permet notamment l'apprentissage de la lecture, de l'écriture et des bases des mathématiques. Les enfants débutent leurs études primaires vers l'âge de 6 ans et les achèvent vers l'âge de 11 ans.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;
    ///     skos:definition : "A primary school (or elementary school in American English and often in Canadian English) is a school in which children receive primary or elementary education from the age of about five to twelve, coming after preschool and before secondary school. (In some countries there is an intermediate stage of middle school between primary and secondary education.)" &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:label : primary schoolrdfs:label : école primaire</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PrimarySchool">cwrc:PrimarySchool</a>
    /// </summary>
    let PrimarySchool = _prefixId.prefix "PrimarySchool"
    /// <summary>
    ///   <para>skos:definition : «Les écoles privées sont des écoles qui ne sont pas administrées par leur gouvernement local, étatique ou national et qui conservent donc le droit de sélectionner leurs élèves et sont financées, en tout ou en partie grâce aux frais de scolarité qu'elle demande à ses élèves, plutôt qu'entièrement par des fonds gouvernementaux. La plupart des écoles privées offrent des bourses d'étude qui permettent de rendre la fréquentation plus abordable pour des étudiants possédant un talent quelconque, généralement au niveau académique ou sportif. Le terme école privée désigne habituellement une école primaire ou secondaire et n'est que très rarement utilisé pour désigner une université.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : "Private schools, also known as independent schools, non-governmental, or nonstate schools, are not administered by local, state or national governments; thus, they retain the right to select their students and are funded in whole or in part by charging their students tuition, rather than relying on mandatory taxation through public (government) funding; at some private schools students may be able to get a scholarship, which makes the cost cheaper, depending on a talent the student may have (e.g. sport scholarship, art scholarship, academic scholarship), financial need, or tax credit scholarships that might be available." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:label : école privéerdfs:label : private school</para>
    ///   <para>rdfs:comment : La description de ce terme est basée sur celle de DBPedia.rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#PrivateSchool">cwrc:PrivateSchool</a>
    /// </summary>
    let PrivateSchool = _prefixId.prefix "PrivateSchool"
    /// <summary>
    ///   <para>skos:definition : A person's professional role (e.g. Doctor Jane Smith) or designates membership in a professional society (e.g. John Smith, Esquire).skos:definition : </para>
    ///   <para>rdfs:label : professional titlerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ProfessionalTitle">cwrc:ProfessionalTitle</a>
    /// </summary>
    let ProfessionalTitle = _prefixId.prefix "ProfessionalTitle"
    /// <summary>
    ///   <para>skos:definition : Indicates both names and descriptive phrases (e.g. "A Lover of Her Sex" is a pseudonym for Mary Astell) used in publishing to conceal the identity of the author or to represent a persona.skos:definition : </para>
    ///   <para>rdfs:label : pseudonymrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Pseudonym">cwrc:Pseudonym</a>
    /// </summary>
    let Pseudonym = _prefixId.prefix "Pseudonym"
    let PunctiveTime = _prefixId.prefix "PunctiveTime"
    let Race = _prefixId.prefix "Race"
    /// <summary>
    ///   <para>skos:definition :
    ///       Sous-classe de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;, cette propriété indique l'appartenance raciale ou la couleur d'une personne, souvent telle qu'elle est présupposée, perçue ou autrement assignée selon des conventions culturelles, en parallèle avec le contexte fourni par les annotation de &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; lorsqu'il est présent. Même si les catégories de race ou de couleur sont fréquemment manipulées au service d'intérêts déplorables, leurs répercussions idéologiques et matérielles sur la formation identitaire requiert qu'on les prenne en compte. Ces catégories changeantes, historiquement constituées, développées de façon intéressée, et dont l'usage doit être resitué en contexte sont enfin comprises ici comme discursives et représentationnelles, même si leurs répercussions matérielles sont bien réelles. Ce sont donc des constructions sociales: «Le fait d'appartenir ou non à une race donnée n'est rien de plus que l'acceptation sociale et l'attribution sociétale d'une race à une personne» &lt;a href="#cwrc:aec674cf-2108-4977-be3a-9317efe35aa9"&gt;(Damon Sajnani, 2015)&lt;/a&gt;.
    ///       Cette ontologie ne prétend donc pas offrir un ensemble de catégories raciales exact, complètement défini, ou mutuellement exclusif, ce qui est impossible étant donné leur utilisation en changement constant et leur chevauchement mutuel ou avec d'autres catégories identitaires utilisées pour l'ethnicité, la géographie ou la nationalité. Les personnes qui appliquent ces catégories et sous-catégories sont encouragées à ne pas faire fonctionner les identités privilégiées comme si elles étaient consensuelles et évidentes, ou à utiliser cette classe seulement en relation avec des populations marginalisées. Les personnes préoccupées par le fait que «blanc» et «noir» sont des catégories homogénéisantes sont encouragées à atteindre la spécificité à travers la pluralité des catégories et les représentations intersectionnelles, ainsi qu'à consulter les annotations associés à &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; s'ils sont fournis.
    ///     skos:definition :
    ///       A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;, this property indicates a person's race or colour, often as presumed, perceived, or otherwise assigned according to cultural conventions, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. Despite the ways in which categories of race or colour frequently serve heinous interests, their ideological and material impacts in the formation of identities requires recognition. These are shifting, historically constituted, and interestedly deployed categories whose use must be situated contextually and which are understood here finally as discursive or representational although they have real material impacts. They are thus as social constructs: "There is nothing more to being, or not being, a given race than the social acceptance and societal ascription of a race to a person" &lt;a href="#cwrc:aec674cf-2108-4977-be3a-9317efe35aa9"&gt;(Damon Sajnani, 2015)&lt;/a&gt;. This ontology therefore does not attempt to lay out an exact, fully defined, or mutually exclusive set of racial categories: this is an impossibility given their shifting use and the overlap among them and with identity categories for ethnicity, geography, and nationality. Those applying this class and its instances are encouraged not to let privileged identities operate as an unspoken given or to use this class solely in relation to the marginalized. Those concerned about "white" and "black" as homogenizing categories are encouraged to reach for specificity through plural categories and representations of intersectionality, and to consult &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations, if available.
    ///     </para>
    ///   <para>rdfs:label : race ou couleurrdfs:label : race or colour</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#RaceColour">cwrc:RaceColour</a>
    /// </summary>
    let RaceColour = _prefixId.prefix "RaceColour"
    let RaceEthnicity = _prefixId.prefix "RaceEthnicity"
    /// <summary>
    ///   <para>rdfs:label : race or ethnicity contextrdfs:label : contexte ethnique ou racial</para>
    ///   <para>skos:definition :
    ///       Contexte Ethnique ou Racial est une sous-classe importante de Contexte, et est associée aux sous-classes &lt;a href="#RaceColour" title="#RaceColour"&gt;race ou couleur&lt;/a&gt; et &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicité&lt;/a&gt; et parfois à d'autres formes culturelles. Les annotations entrées en tant que Contexte Ethnique ou Racial fournissent des renseignements de contextualisation et des discussions sur l'identité d'un sujet concernant son appartenance raciale et/ou son ethnicité.
    ///       Même si les catégories de race et d'ethnicité sont fréquemment manipulées au service d'intérêts déplorables, leurs répercussions idéologiques et matérielles sur la formation identitaire requièrent qu'on les prenne en compte. Ces catégories sont changeantes, historiquement constituées, développées de façon intéressée, et leur usage doit être resitué dans leur contexte; elles sont finalement comprises ici comme discursives et représentationnelles, même si elles ont de réelles répercussions matérielles. Elles sont entendues comme des constructions sociales: «Le fait d'être ou de ne pas être d'une certaine race n'est rien de plus que l'acceptation sociale et l'attribution sociétale d'une race à une personne» &lt;a href="#cwrc:aec674cf-2108-4977-be3a-9317efe35aa9"&gt;(Damon Sajnani, 2015)&lt;/a&gt;
    ///     skos:definition :
    ///       Race or Ethnicity Context is a subclass of &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;, and is associated with the &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; subclasses &lt;a href="#RaceColour" title="#RaceColour"&gt;race or colour&lt;/a&gt; and &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt;, and sometimes other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;. Annotations typed as Race or Ethnicity Context provide contextualizing information about and discussions related to a person's perceived or self-reported identity with regards to race and/or ethnicity (Race or Colour or ethnicity).
    ///       Despite the ways in which categories of Race or Colour and ethnicity frequently serve heinous interests, their ideological and material impacts in the formation of identities requires recognition. These are shifting, historically constituted, and interestedly deployed categories whose use must be situated contextually and are understood here finally as discursive or representational although they have real material impacts. They are thus social constructs: "There is nothing more to being, or not being, a given race than the social acceptance and societal ascription of a race to a person" &lt;a href="#cwrc:aec674cf-2108-4977-be3a-9317efe35aa9"&gt;(Damon Sajnani, 2015)&lt;/a&gt;.
    ///     </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#RaceEthnicityContext">cwrc:RaceEthnicityContext</a>
    /// </summary>
    let RaceEthnicityContext = _prefixId.prefix "RaceEthnicityContext"
    /// <summary>
    ///   <para>skos:definition : Une sous-classe de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt;,décrit la/les religion(s) ou le(s) système(s) de croyance d'une personne. Notez que par commodité nous utilisons l'étiquette Religion pour l'athéisme, même si le terme indique l'absence de religion.skos:definition : A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;, this describes a person's religion(s) or belief system(s). Note that while atheism denotes the absence of religion, we use the Religion label for convenience.</para>
    ///   <para>rdfs:label : religionrdfs:label : religion</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Religion">cwrc:Religion</a>
    /// </summary>
    let Religion = _prefixId.prefix "Religion"
    /// <summary>
    ///   <para>rdfs:label : contexte religieuxrdfs:label : religious context</para>
    ///   <para>skos:definition : Contexte Religieux est une sous-classe de contexte importante. Elle est associée à &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;, sous-classe de Forme Culturelle, et recoupe parfois avec d'autres Formes Culturelles. Les annotations entrées en tant que Contexte Religieux fournissent des informations et des discussions sur la subjectivité d'une personne en lien avec sa religion. Contexte Religieux explore plus en détails les catégories granulaires d'une personne grâce aux propriétés &lt;a href="#hasReligion" title="#hasReligion"&gt;est de confession&lt;/a&gt; Ou &lt;a href="#hasReligionSelfReported" title="#hasReligionSelfReported"&gt;religion (autodéclarée)&lt;/a&gt;.skos:definition : Religion Context is a significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. It is associated with the &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; subclass &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;, and sometimes other intersecting Cultural Forms. Annotations typed as Religion Context provide information about and discussions of a person's subjectivity with regards to their religion. Religion Context provides depth to more granular categorizations of a person indicated by the properties &lt;a href="#hasReligion" title="#hasReligion"&gt;has religious affiliation&lt;/a&gt; or &lt;a href="#hasReligionSelfReported" title="#hasReligionSelfReported"&gt;has religious affiliation (self-reported)&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ReligionContext">cwrc:ReligionContext</a>
    /// </summary>
    let ReligionContext = _prefixId.prefix "ReligionContext"
    /// <summary>
    ///   <para>skos:definition : An organization whose activities are primarily religious.skos:definition : </para>
    ///   <para>rdfs:label : religious organizationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ReligiousOrganization">cwrc:ReligiousOrganization</a>
    /// </summary>
    let ReligiousOrganization = _prefixId.prefix "ReligiousOrganization"
    /// <summary>
    ///   <para>skos:definition : Établissement éducatif officiellement associé de quelque façon avec une religion, allant des écoles paroissiales aux écoles confessionnelles.skos:definition : A school associated formally in some way with a religion, ranging from parochial schools to faith-based schools.</para>
    ///   <para>rdfs:label : école non laïquerdfs:label : religious school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ReligiousSchool">cwrc:ReligiousSchool</a>
    /// </summary>
    let ReligiousSchool = _prefixId.prefix "ReligiousSchool"
    /// <summary>
    ///   <para>skos:definition : A name acquired through a religious role or practice.skos:definition : </para>
    ///   <para>rdfs:label : religious namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ReligousName">cwrc:ReligousName</a>
    /// </summary>
    let ReligousName = _prefixId.prefix "ReligousName"
    /// <summary>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <para>rdfs:label : reproductive history</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ReproductiveHistory">cwrc:ReproductiveHistory</a>
    /// </summary>
    let ReproductiveHistory = _prefixId.prefix "ReproductiveHistory"
    let RobWarren = _prefixId.prefix "RobWarren"
    /// <summary>
    ///   <para>skos:definition : Le rôle d'une Personne ou d'un·e Acteur·ice au sein d'un Évènement, d'une Œuvre Créative ou une Organisation.skos:definition : A role of a Person or Actor in some Event, CreativeWork, or Organisation.</para>
    ///   <para>rdfs:label : rolerdfs:label : Rôle</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Role">cwrc:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>skos:definition : A name which "indicates that a person has a particular role or position in society, such as an official title or rank." This term is derived from the Text Encoding Initiative P5 schema for the 'roleName' element. See &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-roleName.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-roleName.html"&gt;TEI element roleName &lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : role namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#RoleName">cwrc:RoleName</a>
    /// </summary>
    let RoleName = _prefixId.prefix "RoleName"
    /// <summary>
    ///   <para>skos:definition : Indicates cases where the person has a name associated with writing romances, or with romantic writing, for example, Swift's Stella.skos:definition : </para>
    ///   <para>rdfs:label : romance namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#RomanceName">cwrc:RomanceName</a>
    /// </summary>
    let RomanceName = _prefixId.prefix "RomanceName"
    /// <summary>
    ///   <para>skos:definition : A name based on royal status.skos:definition : </para>
    ///   <para>rdfs:label : royal namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#RoyalName">cwrc:RoyalName</a>
    /// </summary>
    let RoyalName = _prefixId.prefix "RoyalName"
    /// <summary>
    ///   <para>skos:definition : A scholarship is an award of financial aid for a student to further their education. Scholarships are awarded based upon various criteria, which usually reflect the values and purposes of the donor or founder of the award. Scholarship money is not required to be repaid.skos:definition : </para>
    ///   <para>rdfs:label : scholarshiprdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Scholarship">cwrc:Scholarship</a>
    /// </summary>
    let Scholarship = _prefixId.prefix "Scholarship"
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>rdfs:label : secondary modern schoolrdfs:label : école secondaire moderne</para>
    ///   <para>skos:definition : "A secondary modern school is a type of secondary school that once existed throughout England, Wales and Northern Ireland, from 1944 until the 1970s under the Tripartite System and still persist in Northern Ireland, where they are usually referred to simply as Secondary schools, and in areas of England, such as Buckinghamshire (where they are referred to as community schools), Lincolnshire, Wirral Medway and Kent where they are called high schools. " &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «Les écoles secondaires modernes, ou Secondary Technical Schools (en), avaient pour objectif une professionnalisation rapide de leur élèves.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:comment : La description de ce terme est basée sur celle de DBPedia.rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SecondaryModernSchool">cwrc:SecondaryModernSchool</a>
    /// </summary>
    let SecondaryModernSchool = _prefixId.prefix "SecondaryModernSchool"
    /// <summary>
    ///   <para>rdfs:label : collègerdfs:label : secondary school</para>
    ///   <para>skos:definition : "A secondary school is both an organization that provides secondary education and the building where this takes place. Some secondary schools can provide both lower secondary education and upper secondary education (levels 2 and 3 of the ISCED scale), but these can also be provided in separate schools, as in the American middle school- high school system. Secondary schools typically follow on from primary schools and lead into vocational and tertiary education. Attendance is compulsory in most countries for students between the ages of 11 and 16. The organisations, buildings, and terminology are more or less unique in each country." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «En France, le collège est un établissement d'enseignement — public ou privé — qui se situe entre l'école primaire et le lycée et assure le premier niveau de l'enseignement secondaire (de la 6e à la 3e) en principe de 11 à 14 / 15 ans environ (l'âge obligatoire minimum de sortie scolaire est de 16 ans en France).» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SecondarySchool">cwrc:SecondarySchool</a>
    /// </summary>
    let SecondarySchool = _prefixId.prefix "SecondarySchool"
    /// <summary>
    ///   <para>skos:definition : École qui n'est pas formellement associée à quelque organisation religieuse et/ou officiellement laïque dans ses principes éducatifs, souvent (mais pas toujours) financée publiquement dans les pays où la religion est séparée de l'État.skos:definition : A school that is not formally associated with a religious organization and/or one that is avowedly secular in its educational principles, often but not always publicly-funded institutions that are funded by countries with a separation between religion and the state.</para>
    ///   <para>rdfs:label : école laïquerdfs:label : secular school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SecularSchool">cwrc:SecularSchool</a>
    /// </summary>
    let SecularSchool = _prefixId.prefix "SecularSchool"
    /// <summary>
    ///   <para>skos:definition : A self-chosen name used in everyday life rather than only on title-pages as is the case for a &lt;a href="#pseudonym" title="#pseudonym"&gt;[http://sparql.cwrc.ca/ontologies/cwrc#pseudonym]&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : self constructed namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SelfConstructedName">cwrc:SelfConstructedName</a>
    /// </summary>
    let SelfConstructedName = _prefixId.prefix "SelfConstructedName"
    /// <summary>
    ///   <para>skos:definition : Education context related to learning conducted independently.skos:definition : Contexte éducatif lié à l'apprentissage mené de façon autonome.</para>
    ///   <para>rdfs:label : self taught education contextrdfs:label : contexte éducatif autodidacte</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SelfTaughtEducationContext">cwrc:SelfTaughtEducationContext</a>
    /// </summary>
    let SelfTaughtEducationContext = _prefixId.prefix "SelfTaughtEducationContext"
    let SexIdentity = _prefixId.prefix "SexIdentity"
    let SexualIdentity = _prefixId.prefix "SexualIdentity"
    /// <summary>
    ///   <para>skos:definition : A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; and linked to &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexuality context&lt;/a&gt;, Sexuality properties indicate in a word or phrase identifications or aspects of sexuality (i.e., "lesbian," "monogamous," "heterosexual" but also "promiscuous") not as a means of shutting down but advancing investigation and critical analysis of these identifications. The association assumes that sexual identity does not function in an essentialist manner but can be plural and fluid, so multiple designations can be applied to a single person can be associated with multiple terms. Sexual identity may come from the subject her/himself or be ascribed by others. Terms may be in tension or mutually exclusive, they may reflect different life stages, and they may or may not reflect actual sexual practices. Linking a person to the term &lt;a href="#lesbian" title="#lesbian"&gt;lesbianism&lt;/a&gt; as a sexual identity, for instance, does not necessarily signify that the subject was in any definitive sense a lesbian; such identifications are often impossible for reasons of historical gaps and silences. As far as living persons are concerned, our practice is to draw only on widely circulated public sources or disclosures from the subject her/himself in order to avoid inadvertently outing someone. See (&lt;a href="#cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a"&gt;Campbell and Cowan, 2016&lt;/a&gt;)skos:definition : Une sous-classe de &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt; liée à &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexualité en contexte&lt;/a&gt;, les propriétés de Sexualité indiquent en un mot ou en une phrase les identifications ou les aspects de la sexualité (par exemple «lesbienne», «monogame», «hétérosexuelle», mais aussi «promiscuité»), non pas pour clore la discussion mais pour développer l'étude et l'analyse critique de ces catégories. Comme l'identité sexuelle peut être plurielle et fluide, une même personne est susceptible d'être associée à plusieurs termes. L'identité sexuelle peut être formulée par la personne elle-même ou être assignée par d'autres individus. Les termes utilisés peuvent se trouver en tension ou se montrer incompatibles, et reflètent différentes périodes de l'existence. Par exemple, lier une personne au terme «lesbienne» comme classe de sexualité ne signifie pas nécessairement que cette dernière était définitivement lesbienne, car une telle identification est souvent impossible à cause de lacunes et de silences historiques. En ce qui concerne les personnes toujours en vie, nous ne nous appuyons que sur des sources ou des déclarations publiques faites par le sujet elle/lui-même afin de ne pas dévoiler par inadvertance des informations privées sur sa sexualité. Voir &lt;a href="#cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a"&gt;Campbell and Cowan 2016&lt;/a&gt;</para>
    ///   <para>rdfs:label : sexualitérdfs:label : sexuality</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Sexuality">cwrc:Sexuality</a>
    /// </summary>
    let Sexuality = _prefixId.prefix "Sexuality"
    /// <summary>
    ///   <para>skos:definition : Sexualité En Contexte est une sous-classe de contexte importante. Les annotations de Sexualité En Contexte fournissent des renseignements et des discussions sur la sexualité et l'identité sexuelle d'une personne grâce à Sexualité ou Sexualité Autodéclarée. Elle n'est pas vouée à répertorier les expériences sexuelles et les relations intimes, même si certaines d'entre elles peuvent être évoquées pour indiquer leurs conséquences sur la vie du sujet ou la connaissance qu'elle a de sa propre sexualité. Ces efforts de contextualisation permettent de reconnaître l'existence de questions complexes qui entourent la sexualité, comme par exemple les politiques de délation, la spécificité historique de certaines catégories comme "inversion sexuelle", la réappropriation de termes dénigrants ou les mutliples constructions discursives. Il existe d'importantes politiques de confidentialité qui protègent les personnes contre la divulgation d'informations privées sur leur sexualité, leur orientation sexuelle et leur identité sexuelle. Pour les personnes toujours en vie, notre pratique est donc de ne nous appuyer que sur des sources ou des déclarations publiques venant des sujets eux-mêmes, afin de ne pas dévoiler par inadvertance des informations privées sur leur sexualité. Voir (&lt;a href="#cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a"&gt;Campbell and Cowan, 2016&lt;/a&gt;)
    ///     skos:definition : Sexuality Context is a significant subclass of &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. Annotations typed as Sexuality Context provide information about and discussions of a person's subjectivity with regards to their sexuality and sexual identity. Sexuality Context provides depth to more granular categorizations of a person through the sexuality or sexuality self-reported properties. It does not provide context for individual sexual experiences and relationships (for which see &lt;a href="#IntimateRelationshipsContext" title="#IntimateRelationshipsContext"&gt;intimate relationships context&lt;/a&gt;), although specific relationships may be invoked to indicate the impact on a subject's life and understanding of their own sexuality. Contextualizations allow recognition of the complicated politics of sexuality, for example, considerations regarding outing, the historical specificity of some categories such as "congenital invert," the appropriation of derogatory terms, and the multiplicity of constructions. There are important politics of privacy with respect to the disclosure of a subject's sexuality, sexual orientation, and sexual identity. As far as living persons are concerned, recommended practice is to draw only on widely circulated public sources or disclosures from the subject her/himself in order to avoid inadvertently outing someone. See (&lt;a href="#cwrc:9144c07e-d14f-4371-8d28-7545b7337a4a"&gt;Campbell and Cowan, 2016&lt;/a&gt;)
    ///     </para>
    ///   <para>rdfs:label : sexuality contextrdfs:label : sexualité en contexte</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SexualityContext">cwrc:SexualityContext</a>
    /// </summary>
    let SexualityContext = _prefixId.prefix "SexualityContext"
    /// <summary>
    ///   <para>skos:definition : "Single-sex education, also known as single-gender education, is the practice of conducting education where male and female students attend separate classes or in separate buildings or schools. The practice was common before the twentieth century, particularly in secondary education and higher education. Single-sex education in many cultures is advocated on the basis of tradition as well as religion, and is practiced in many parts of the world. Recently, there has been a surge of interest and establishment of single-sex schools due to educational research. Single sex education is practiced in many Muslim majority countries; while in the West it is most popular in Belgium, Chile, Singapore, the United Kingdom, Hong Kong, Israel, New Zealand, Australia, South Korea. Motivations for such education range from religious ideas of sex segregation to beliefs that the sexes learn and behave differently, and, as such, they thrive in a single sex environment. In the 19th century, in Western countries, single sex girls' finishing schools, and women's colleges offered women a chance to education at a time when they were denied access to mainstream educational institutions. The former were especially common in Switzerland, the latter in the US and the UK, which were pioneers in women's education." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : L'éducation non mixte, également connue sous le nom d'éducation unisexe, désigne un type d'éducation qui implique la séparation des élèves en fonction de leur sexe de naissance, qui sont réparti·e·s dans des classes, des bâtiments ou des écoles séparés.</para>
    ///   <para>rdfs:label : éducation non mixterdfs:label : single-sex school</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SingleSexSchool">cwrc:SingleSexSchool</a>
    /// </summary>
    let SingleSexSchool = _prefixId.prefix "SingleSexSchool"
    /// <summary>
    ///   <para>skos:definition : Une sous-catégorie de culturalForm, les termes de socialClass associent les sujets à des groupes sociaux spécifiques, en prenant en compte le fait que ces catégories et leur application aux individus sont contestables et peuvent changer au fil du temps. L'association à une classe sociale peut ou a pu être assumée par le sujet elle/lui-même ou attribuée par d'autres. Contrairement aux notes comme &lt;a href="#SocialClassContext" title="#SocialClassContext"&gt;contexte social&lt;/a&gt;, qui contiennent les détails des discussions autour de le statut social du sujet, socialClass relie un mot ou une phrase référant à une classe spécifique qui renvoie à des périodes historiques antérieures spécifiques des Îles Britanniques. La notion de classe sociale a été construite et théorisée de diverses manières, et est d'autant plus complexe pour les femmes puisqu'elles étaient censées adopter le statut social de leur père et/ou de leur mari. La terminologie ici utilisée réfère à des groupes sociaux élémentaires qui se recoupent avec d'autres facteurs comme la richesse.skos:definition : A subclass of &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;, socialClass terms associate subjects with a specific social group, recognizing that such categories and their application to individuals are contested and can change over time. The association may be or have been embraced by the subject her/himself or attributed by others. Unlike Notes typed as &lt;a href="#SocialClassContext" title="#SocialClassContext"&gt;social class context&lt;/a&gt;, which contain detailed discussion of a subject's class position, socialClass links to a word or phrase signifying a particular construction of class, with particular reference to earlier historical periods in the British Isles. Social class has been variously constructed and theorized, sometimes overlaps with &lt;a href="#Occupation" title="#Occupation"&gt;occupation&lt;/a&gt;, and for women is further complicated by the fact that women were understood to take their social status from fathers and/or husbands. The terminology used here reflects quite basic social groupings that intersect with other factors such as wealth.</para>
    ///   <para>rdfs:label : social classrdfs:label : classe sociale</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClass">cwrc:SocialClass</a>
    /// </summary>
    let SocialClass = _prefixId.prefix "SocialClass"
    /// <summary>
    ///   <para>rdfs:label : social class contextrdfs:label : contexte social</para>
    ///   <para>skos:definition : Social Class Context is a significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Social Class Context provide information about and discussions of a person's cultural formation in relation to social class identities and sometimes other intersecting Cultural Forms. Social Class Context provides depth to more granular indications of social class through the Social Class property&lt;a href="#cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7"&gt;(Orlando, 2006).&lt;/a&gt;skos:definition : Contexte Social est une sous-classe de contexte importante. Les annotations de Contexte Social fournissent des informations et des discussions relatives à la classe sociale et parfois à d'autres Formes Culturelles d'une personne. Contexte Social explore plus en détails les indications granulaires sur la classe sociale à travers les propriétés de Classe Sociale.&lt;a href="#cwrc:d596c4a0-ecaf-4739-8a58-3e0af7dba4c7"&gt;(Orlando, 2006)&lt;/a&gt;</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClassContext">cwrc:SocialClassContext</a>
    /// </summary>
    let SocialClassContext = _prefixId.prefix "SocialClassContext"
    let SocialClassIdentity = _prefixId.prefix "SocialClassIdentity"
    /// <summary>
    ///   <para>skos:definition : Events, including indications of larger trends, with social implications, such as shifts in technology, science, medicine, law, or education, domestic conditions such as housing, clothes, or food and food supply, or the changing positions and civic involvements of marginalized groups.skos:definition : </para>
    ///   <para>rdfs:label : social climaterdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SocialClimate">cwrc:SocialClimate</a>
    /// </summary>
    let SocialClimate = _prefixId.prefix "SocialClimate"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as spatial context provide information about and discussions of aspects of a person's connections to geospatial locations. Spatial information is also associated in a range of ways with other properties and events such as a person's &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;, a place of publication, or the setting of literary texts.skos:definition : </para>
    ///   <para>rdfs:label : spatial contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SpatialContext">cwrc:SpatialContext</a>
    /// </summary>
    let SpatialContext = _prefixId.prefix "SpatialContext"
    /// <summary>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.</para>
    ///   <para>skos:definition : State school est un terme utilisé en Australie, en Nouvelle-Zélande et au Royaume-Uni pour distinguer les écoles gérées par le gouvernement des écoles privées.skos:definition : "State schools (also known as public schools outside of England and Wales) generally refer to primary or secondary schools mandated for or offered to all children without charge, funded in whole or in part by taxation. The term may also refer to public institutions of post-secondary education." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:label : state schoolrdfs:label : state school</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#StateSchool">cwrc:StateSchool</a>
    /// </summary>
    let StateSchool = _prefixId.prefix "StateSchool"
    /// <summary>
    ///   <para>skos:definition : A Studentship is a type of academic scholarship.skos:definition : </para>
    ///   <para>rdfs:label : studentshiprdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Studentship">cwrc:Studentship</a>
    /// </summary>
    let Studentship = _prefixId.prefix "Studentship"
    /// <summary>
    ///   <para>skos:definition : A courtesy title associated with the British or other peerage.skos:definition : </para>
    ///   <para>rdfs:label : styled namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#StyledName">cwrc:StyledName</a>
    /// </summary>
    let StyledName = _prefixId.prefix "StyledName"
    /// <summary>
    ///   <para>skos:definition : A subject's last name at birth, often a family (inherited) name, as opposed to a &lt;a href="#Forename" title="#Forename"&gt;forename&lt;/a&gt; or &lt;a href="#Nickname" title="#Nickname"&gt;nickname&lt;/a&gt;." This term is derived from the Text Encoding Initiative P5 schema 'surname' element. See also &lt;a href="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-surname.html" title="http://www.tei-c.org/release/doc/tei-p5-doc/en/html/ref-surname.html"&gt;TEI element surname &lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : surnamerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#Surname">cwrc:Surname</a>
    /// </summary>
    let Surname = _prefixId.prefix "Surname"
    let SusanBrown = _prefixId.prefix "SusanBrown"
    /// <summary>
    ///   <para>skos:definition : A name by which a person holds an account for a platform or service.skos:definition : </para>
    ///   <para>rdfs:label : system namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#SystemName">cwrc:SystemName</a>
    /// </summary>
    let SystemName = _prefixId.prefix "SystemName"
    /// <summary>
    ///   <para>skos:definition : Ensemble des étiquettes ambigues au sein du jeu d'étiquettes d'Orlando.skos:definition : Collection of ambiguous or overloaded labels associated with contested concepts.</para>
    ///   <para>rdfs:label : étiquettes textuellesrdfs:label : textual label</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#TextLabels">cwrc:TextLabels</a>
    /// </summary>
    let TextLabels = _prefixId.prefix "TextLabels"
    /// <summary>
    ///   <para>skos:definition : A formal title in the British and other peerages, including of a life peer. Peeresses may be described as titled, although in strict terms, unless one holds a title "in her own right", these are &lt;a href="#StyledName" title="#StyledName"&gt;styled names&lt;/a&gt; or courtesy titles.skos:definition : </para>
    ///   <para>rdfs:label : titled namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#TitledName">cwrc:TitledName</a>
    /// </summary>
    let TitledName = _prefixId.prefix "TitledName"
    /// <summary>
    ///   <para>skos:definition : "A vocational school, sometimes called a trade school or vocational college, is a post-secondary educational institution designed to provide vocational education, or technical skills required to perform the tasks of a particular and specific job. Vocational schools are traditionally distinguished from four-year colleges by their focus on job-specific training to students who are typically bound for one of the skilled trades, rather than providing academic training for students pursuing careers in a professional discipline. While many schools have largely adhered to this convention, the purely vocational focus of other trade schools began to shift in the 1990s "toward a broader preparation that develops the academic" as well as technical skills of their students." &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;skos:definition : «En France, le lycée professionnel (LP) est un établissement d'enseignement professionnel qui offre un enseignement professionnel en relation avec les métiers des entreprises, afin d'acquérir des compétences, des connaissances et des savoir-faire dans un domaine professionnel. Son but est l'insertion socioprofessionnelle.» &lt;a href="#cwrc:c5e7bace-95bb-4820-bd7d-6bb97c1badc5"&gt;(DBpedia, 2018)&lt;/a&gt;</para>
    ///   <para>rdfs:label : trade schoolrdfs:label : lycée professionnel</para>
    ///   <para>rdfs:comment : The description for this term is indebted to DBpedia.rdfs:comment : La description de ce terme est basée sur celle de DBPedia.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#TradeSchool">cwrc:TradeSchool</a>
    /// </summary>
    let TradeSchool = _prefixId.prefix "TradeSchool"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Violence Context provide information about and discussions of instances of physical, sexual, and undue emotional abuse, whether the person was subject to the violence or perpetrated it. Broadly conceived to include the effect of exposure to violence of which the person was neither perpetrator nor survivor.skos:definition : </para>
    ///   <para>rdfs:label : violence contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ViolenceContext">cwrc:ViolenceContext</a>
    /// </summary>
    let ViolenceContext = _prefixId.prefix "ViolenceContext"
    /// <summary>
    ///   <para>skos:definition : A significant subclass of &lt;a href="#Context" title="#Context"&gt;context&lt;/a&gt;. Annotations typed as Wealth Context provide information about and discussions of a person's economic standing, including inheritance, property ownership, pensions, and personal financial disasters. See also the &lt;a href="#OccupationContext" title="#OccupationContext"&gt;occupation context&lt;/a&gt; and &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;, particularly for &lt;a href="#SocialClassContext" title="#SocialClassContext"&gt;social class context&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : wealth contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#WealthContext">cwrc:WealthContext</a>
    /// </summary>
    let WealthContext = _prefixId.prefix "WealthContext"
    /// <summary>
    ///   <para>skos:definition : A subclass of &lt;a href="#HealthContext" title="#HealthContext"&gt;health context&lt;/a&gt;. Annotations typed as women 's health context describe an aspect of a person's health related to being a woman. Often closely connected to or overlapping with &lt;a href="#ReproductiveHistory" title="#ReproductiveHistory"&gt;reproductive history&lt;/a&gt;. See &lt;a href="https://en.wikipedia.org/wiki/Women%27s_health" title="https://en.wikipedia.org/wiki/Women%27s_health"&gt;Women's health - Wikipedia&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : women's health contextrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#WomensHealthContext">cwrc:WomensHealthContext</a>
    /// </summary>
    let WomensHealthContext = _prefixId.prefix "WomensHealthContext"

    let a5686049_f450_415c_9ca6_deee26e30899 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899"

    let a5686049_f450_415c_9ca6_deee26e30899_4ee64522b2 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-4ee64522b2"

    let a5686049_f450_415c_9ca6_deee26e30899_588ae315d6 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-588ae315d6"

    let a5686049_f450_415c_9ca6_deee26e30899_9856975261 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-9856975261"

    let a5686049_f450_415c_9ca6_deee26e30899_b3f841f5c0 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-b3f841f5c0"

    let a5686049_f450_415c_9ca6_deee26e30899_dc53f66118 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-dc53f66118"

    let a5686049_f450_415c_9ca6_deee26e30899_partof = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-partof"

    let a5686049_f450_415c_9ca6_deee26e30899_partof_79e6794d92 = _prefixId.prefix "a5686049-f450-415c-9ca6-deee26e30899-partof-79e6794d92"

    let a647a149_3420_4a0d_8462_03900131060e = _prefixId.prefix "a647a149-3420-4a0d-8462-03900131060e"

    let a647a149_3420_4a0d_8462_03900131060e_62fc70c238 = _prefixId.prefix "a647a149-3420-4a0d-8462-03900131060e-62fc70c238"

    let a647a149_3420_4a0d_8462_03900131060e_67d1668522 = _prefixId.prefix "a647a149-3420-4a0d-8462-03900131060e-67d1668522"

    let a647a149_3420_4a0d_8462_03900131060e_d623563918 = _prefixId.prefix "a647a149-3420-4a0d-8462-03900131060e-d623563918"

    let a647a149_3420_4a0d_8462_03900131060e_d9d06e8cbe = _prefixId.prefix "a647a149-3420-4a0d-8462-03900131060e-d9d06e8cbe"

    let aa8dae29_558b_4bda_9859_9ed43faede36 = _prefixId.prefix "aa8dae29-558b-4bda-9859-9ed43faede36"

    let aa8dae29_558b_4bda_9859_9ed43faede36_04b657798c = _prefixId.prefix "aa8dae29-558b-4bda-9859-9ed43faede36-04b657798c"

    let aa8dae29_558b_4bda_9859_9ed43faede36_45528df81c = _prefixId.prefix "aa8dae29-558b-4bda-9859-9ed43faede36-45528df81c"

    let aaa909f5_ffb5_4995_8245_b169d3c64746 = _prefixId.prefix "aaa909f5-ffb5-4995-8245-b169d3c64746"

    let aaa909f5_ffb5_4995_8245_b169d3c64746_352a867f1c = _prefixId.prefix "aaa909f5-ffb5-4995-8245-b169d3c64746-352a867f1c"

    let aaa909f5_ffb5_4995_8245_b169d3c64746_706552b3f4 = _prefixId.prefix "aaa909f5-ffb5-4995-8245-b169d3c64746-706552b3f4"

    let aaa909f5_ffb5_4995_8245_b169d3c64746_partof = _prefixId.prefix "aaa909f5-ffb5-4995-8245-b169d3c64746-partof"

    let abolitionism = _prefixId.prefix "abolitionism"
    let abolitionist = _prefixId.prefix "abolitionist"
    let abortion = _prefixId.prefix "abortion"
    let abrahamicReligions = _prefixId.prefix "abrahamicReligions"
    let academic = _prefixId.prefix "academic"
    let accountant = _prefixId.prefix "accountant"
    let activist = _prefixId.prefix "activist"
    let actorManager = _prefixId.prefix "actorManager"
    let adjudicator = _prefixId.prefix "adjudicator"
    let administrator = _prefixId.prefix "administrator"
    let adoption = _prefixId.prefix "adoption"
    let adventism = _prefixId.prefix "adventism"
    let advertising = _prefixId.prefix "advertising"
    let advocate = _prefixId.prefix "advocate"

    let aec674cf_2108_4977_be3a_9317efe35aa9 = _prefixId.prefix "aec674cf-2108-4977-be3a-9317efe35aa9"

    let aec674cf_2108_4977_be3a_9317efe35aa9_b6c5d2bffd = _prefixId.prefix "aec674cf-2108-4977-be3a-9317efe35aa9-b6c5d2bffd"

    let aec674cf_2108_4977_be3a_9317efe35aa9_partof = _prefixId.prefix "aec674cf-2108-4977-be3a-9317efe35aa9-partof"

    /// <summary>
    ///   <para>skos:definition : Affected entities link to the Object or Class that was modified within a change set, this can be any rdf:resource. A &lt;a href="#ChangeSet" title="#ChangeSet"&gt;change set&lt;/a&gt; may have 0 to many affected entities.skos:definition : </para>
    ///   <para>rdfs:label : affected entityrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#affectedEntity">cwrc:affectedEntity</a>
    /// </summary>
    let affectedEntity = _prefixId.prefix "affectedEntity"
    let african_AmericanEthnicity = _prefixId.prefix "african-AmericanEthnicity"
    let africanEthnicity = _prefixId.prefix "africanEthnicity"
    let africanNationalHeritage = _prefixId.prefix "africanNationalHeritage"
    let africanNationalIdentity = _prefixId.prefix "africanNationalIdentity"
    let afro_CaribbeanRaceColour = _prefixId.prefix "afro-CaribbeanRaceColour"
    let agent = _prefixId.prefix "agent"
    let agnosticism = _prefixId.prefix "agnosticism"
    let aidsActivism = _prefixId.prefix "aidsActivism"
    let airForce = _prefixId.prefix "airForce"
    let airRaidWarden = _prefixId.prefix "airRaidWarden"
    let aircraftIndustry = _prefixId.prefix "aircraftIndustry"
    let airman = _prefixId.prefix "airman"
    /// <summary>
    ///   <para>skos:definition : Links a &lt;a href="#NaturalPerson" title="#NaturalPerson"&gt;natural person&lt;/a&gt; to a &lt;a href="#ChangeSet" title="#ChangeSet"&gt;change set&lt;/a&gt; entry.skos:definition : </para>
    ///   <para>rdfs:label : altered byrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#alteredBy">cwrc:alteredBy</a>
    /// </summary>
    let alteredBy = _prefixId.prefix "alteredBy"
    let alternativeMedicine = _prefixId.prefix "alternativeMedicine"
    let ambulanceWorker = _prefixId.prefix "ambulanceWorker"
    let americanNationalism = _prefixId.prefix "americanNationalism"
    let anarchism = _prefixId.prefix "anarchism"
    /// <summary>
    ///   <para>rdfs:label : ancestor ofrdfs:label : ancestor de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ancestorOf">cwrc:ancestorOf</a>
    /// </summary>
    let ancestorOf = _prefixId.prefix "ancestorOf"
    let anglicanism = _prefixId.prefix "anglicanism"
    let anglo_IndianNationalIdentity = _prefixId.prefix "anglo-IndianNationalIdentity"
    let anglo_IrishEthnicity = _prefixId.prefix "anglo-IrishEthnicity"
    let anglo_IrishNationalHeritage = _prefixId.prefix "anglo-IrishNationalHeritage"
    let anglo_IrishNationalIdentity = _prefixId.prefix "anglo-IrishNationalIdentity"
    let anglo_IrishRaceColour = _prefixId.prefix "anglo-IrishRaceColour"
    let anglo_NormanEthnicity = _prefixId.prefix "anglo-NormanEthnicity"
    let animalWelfareAdvocacy = _prefixId.prefix "animalWelfareAdvocacy"
    let anti_American = _prefixId.prefix "anti-American"
    let anti_Antisemitism = _prefixId.prefix "anti-Antisemitism"
    let anti_Apartheid = _prefixId.prefix "anti-Apartheid"
    let anti_Boer = _prefixId.prefix "anti-Boer"
    let anti_Bolshevism = _prefixId.prefix "anti-Bolshevism"
    let anti_Bonapartism = _prefixId.prefix "anti-Bonapartism"
    let anti_British = _prefixId.prefix "anti-British"
    let anti_CapitalPunishment = _prefixId.prefix "anti-CapitalPunishment"
    let anti_Capitalism = _prefixId.prefix "anti-Capitalism"
    let anti_Caste = _prefixId.prefix "anti-Caste"
    let anti_Catholicism = _prefixId.prefix "anti-Catholicism"
    let anti_Censorship = _prefixId.prefix "anti-Censorship"
    let anti_Communism = _prefixId.prefix "anti-Communism"
    let anti_Conscriptionism = _prefixId.prefix "anti-Conscriptionism"
    let anti_ContagiousDiseasesAct = _prefixId.prefix "anti-ContagiousDiseasesAct"
    let anti_CorporalPunishment = _prefixId.prefix "anti-CorporalPunishment"
    let anti_Dreyfusard = _prefixId.prefix "anti-Dreyfusard"
    let anti_European = _prefixId.prefix "anti-European"
    let anti_Fascism = _prefixId.prefix "anti-Fascism"
    let anti_Federalism = _prefixId.prefix "anti-Federalism"
    let anti_Feminism = _prefixId.prefix "anti-Feminism"
    let anti_Globalism = _prefixId.prefix "anti-Globalism"
    let anti_Imperialism = _prefixId.prefix "anti-Imperialism"
    let anti_Jacobin = _prefixId.prefix "anti-Jacobin"
    let anti_Jacobite = _prefixId.prefix "anti-Jacobite"
    let anti_LandLeague = _prefixId.prefix "anti-LandLeague"
    let anti_Monarchism = _prefixId.prefix "anti-Monarchism"
    let anti_NuclearMovement = _prefixId.prefix "anti-NuclearMovement"
    let anti_Pacifism = _prefixId.prefix "anti-Pacifism"
    let anti_PovertyMovement = _prefixId.prefix "anti-PovertyMovement"
    let anti_Racism = _prefixId.prefix "anti-Racism"
    let anti_Socialism = _prefixId.prefix "anti-Socialism"
    let anti_Suffrage = _prefixId.prefix "anti-Suffrage"
    let anti_Trade_Unionism = _prefixId.prefix "anti-Trade-Unionism"
    let anti_Urbanism = _prefixId.prefix "anti-Urbanism"
    let anti_Vaccination = _prefixId.prefix "anti-Vaccination"
    let anti_Vivisection = _prefixId.prefix "anti-Vivisection"
    let anti_War = _prefixId.prefix "anti-War"
    let anti_Zionism = _prefixId.prefix "anti-Zionism"
    let anti_masonry = _prefixId.prefix "anti-masonry"
    let antiClericalism = _prefixId.prefix "antiClericalism"
    let antidisestablishmentarianism = _prefixId.prefix "antidisestablishmentarianism"
    let antisemitism = _prefixId.prefix "antisemitism"
    let appeasement = _prefixId.prefix "appeasement"
    let appraiser = _prefixId.prefix "appraiser"
    let arabEthnicity = _prefixId.prefix "arabEthnicity"
    let archaeologist = _prefixId.prefix "archaeologist"
    let architecture = _prefixId.prefix "architecture"
    let archivist = _prefixId.prefix "archivist"
    let aristocrat = _prefixId.prefix "aristocrat"
    let army = _prefixId.prefix "army"
    let artsAdministrator = _prefixId.prefix "artsAdministrator"
    let artsAdvocacy = _prefixId.prefix "artsAdvocacy"
    let artsAdvocate = _prefixId.prefix "artsAdvocate"
    let asceticism = _prefixId.prefix "asceticism"
    let ashkenaziJewishEthnicity = _prefixId.prefix "ashkenaziJewishEthnicity"
    let asianRaceColour = _prefixId.prefix "asianRaceColour"
    let assistant = _prefixId.prefix "assistant"
    let associationInvolvement = _prefixId.prefix "associationInvolvement"
    let astronomer = _prefixId.prefix "astronomer"
    let atheism = _prefixId.prefix "atheism"
    /// <summary>
    ///   <para>rdfs:label : attendsrdfs:label : scolarisation</para>
    ///   <para>skos:definition :  Indique que le sujet fréquente ou a fréquenté un établissement éducatif en particulier ou a reçu une forme d'enseignement spécifiqueskos:definition : Indicates attending or having attended for education either a particular school or a particular type of schooling.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#attends">cwrc:attends</a>
    /// </summary>
    let attends = _prefixId.prefix "attends"
    /// <summary>
    ///   <para>skos:definition : Indicates attending or having attended for education a post-secondary school.skos:definition : </para>
    ///   <para>rdfs:label : attends post-secondary schoolrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#attendsPostSecondarySchool">cwrc:attendsPostSecondarySchool</a>
    /// </summary>
    let attendsPostSecondarySchool = _prefixId.prefix "attendsPostSecondarySchool"
    /// <summary>
    ///   <para>skos:definition : Indicates attending or having attended for education a primary school.skos:definition : </para>
    ///   <para>rdfs:label : attends primary schoolrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#attendsPrimarySchool">cwrc:attendsPrimarySchool</a>
    /// </summary>
    let attendsPrimarySchool = _prefixId.prefix "attendsPrimarySchool"
    /// <summary>
    ///   <para>skos:definition : Indicates attending or having attended for education a secondary school.skos:definition : </para>
    ///   <para>rdfs:label : attends secondary schoolrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#attendsSecondarySchool">cwrc:attendsSecondarySchool</a>
    /// </summary>
    let attendsSecondarySchool = _prefixId.prefix "attendsSecondarySchool"
    let attorneyGeneral = _prefixId.prefix "attorneyGeneral"
    let auctioneer = _prefixId.prefix "auctioneer"
    /// <summary>
    ///   <para>rdfs:label : aunt ofrdfs:label : tante de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#auntOf">cwrc:auntOf</a>
    /// </summary>
    let auntOf = _prefixId.prefix "auntOf"
    let automobileIndustry = _prefixId.prefix "automobileIndustry"
    /// <summary>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <para>rdfs:label : awarded tordfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#awardedTo">cwrc:awardedTo</a>
    /// </summary>
    let awardedTo = _prefixId.prefix "awardedTo"

    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e = _prefixId.prefix "b69cb6a0-ac73-4219-bfb0-e4804ff1403e"

    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e_00295cd251 = _prefixId.prefix "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-00295cd251"

    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e_d3cf0482b8 = _prefixId.prefix "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-d3cf0482b8"

    let b69cb6a0_ac73_4219_bfb0_e4804ff1403e_f478fff214 = _prefixId.prefix "b69cb6a0-ac73-4219-bfb0-e4804ff1403e-f478fff214"

    let b736fb3c_dcde_49f3_aa07_67ce6a42100a = _prefixId.prefix "b736fb3c-dcde-49f3-aa07-67ce6a42100a"

    let b736fb3c_dcde_49f3_aa07_67ce6a42100a_1ca90e57c1 = _prefixId.prefix "b736fb3c-dcde-49f3-aa07-67ce6a42100a-1ca90e57c1"

    let b736fb3c_dcde_49f3_aa07_67ce6a42100a_partof = _prefixId.prefix "b736fb3c-dcde-49f3-aa07-67ce6a42100a-partof"

    let b95a3e61_23f6_4603_bb6b_06703aceb3c9 = _prefixId.prefix "b95a3e61-23f6-4603-bb6b-06703aceb3c9"

    let b95a3e61_23f6_4603_bb6b_06703aceb3c9_16ff462e2c = _prefixId.prefix "b95a3e61-23f6-4603-bb6b-06703aceb3c9-16ff462e2c"

    let b95a3e61_23f6_4603_bb6b_06703aceb3c9_318cb143c9 = _prefixId.prefix "b95a3e61-23f6-4603-bb6b-06703aceb3c9-318cb143c9"

    let b95a3e61_23f6_4603_bb6b_06703aceb3c9_b531d0ad51 = _prefixId.prefix "b95a3e61-23f6-4603-bb6b-06703aceb3c9-b531d0ad51"

    let b9eeccf9_9380_4341_99dc_a83f5ee32909 = _prefixId.prefix "b9eeccf9-9380-4341-99dc-a83f5ee32909"

    let b9eeccf9_9380_4341_99dc_a83f5ee32909_f7b703e604 = _prefixId.prefix "b9eeccf9-9380-4341-99dc-a83f5ee32909-f7b703e604"

    let b9eeccf9_9380_4341_99dc_a83f5ee32909_partof = _prefixId.prefix "b9eeccf9-9380-4341-99dc-a83f5ee32909-partof"

    let bachelorOfArts = _prefixId.prefix "bachelorOfArts"
    let bachelorOfScience = _prefixId.prefix "bachelorOfScience"
    let baker = _prefixId.prefix "baker"
    let bankrupt = _prefixId.prefix "bankrupt"
    let baptistChristianity = _prefixId.prefix "baptistChristianity"
    let baptistChurch = _prefixId.prefix "baptistChurch"

    let bd6e0e18_2543_4310_94da_aae6557df17d = _prefixId.prefix "bd6e0e18-2543-4310-94da-aae6557df17d"

    let bd6e0e18_2543_4310_94da_aae6557df17d_696c1e861a = _prefixId.prefix "bd6e0e18-2543-4310-94da-aae6557df17d-696c1e861a"

    let bd6e0e18_2543_4310_94da_aae6557df17d_7bc3557dcf = _prefixId.prefix "bd6e0e18-2543-4310-94da-aae6557df17d-7bc3557dcf"

    let bd6e0e18_2543_4310_94da_aae6557df17d_8a2569e7f2 = _prefixId.prefix "bd6e0e18-2543-4310-94da-aae6557df17d-8a2569e7f2"

    let bd6e0e18_2543_4310_94da_aae6557df17d_a4adea3de1 = _prefixId.prefix "bd6e0e18-2543-4310-94da-aae6557df17d-a4adea3de1"

    let bdfac2f5_ae45_4af7_941c_ec37b12f1a38 = _prefixId.prefix "bdfac2f5-ae45-4af7-941c-ec37b12f1a38"

    let bdfac2f5_ae45_4af7_941c_ec37b12f1a38_0ee2efb217 = _prefixId.prefix "bdfac2f5-ae45-4af7-941c-ec37b12f1a38-0ee2efb217"

    let bdfac2f5_ae45_4af7_941c_ec37b12f1a38_4c7d285ea3 = _prefixId.prefix "bdfac2f5-ae45-4af7-941c-ec37b12f1a38-4c7d285ea3"

    let beautician = _prefixId.prefix "beautician"
    let beauty = _prefixId.prefix "beauty"
    let beggar = _prefixId.prefix "beggar"
    let behemenism = _prefixId.prefix "behemenism"
    let benedictineOrder = _prefixId.prefix "benedictineOrder"
    let bengaliEthnicity = _prefixId.prefix "bengaliEthnicity"
    let bengaliNationalHeritage = _prefixId.prefix "bengaliNationalHeritage"
    let bibliography = _prefixId.prefix "bibliography"
    let bibliophile = _prefixId.prefix "bibliophile"
    let billCollector = _prefixId.prefix "billCollector"
    let biologist = _prefixId.prefix "biologist"
    let birthControl = _prefixId.prefix "birthControl"
    let birthControlActivism = _prefixId.prefix "birthControlActivism"
    /// <summary>
    ///   <para>rdfs:label : birth date ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#birthDateOf">cwrc:birthDateOf</a>
    /// </summary>
    let birthDateOf = _prefixId.prefix "birthDateOf"
    /// <summary>
    ///   <para>rdfs:label : birth place ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#birthPlaceOf">cwrc:birthPlaceOf</a>
    /// </summary>
    let birthPlaceOf = _prefixId.prefix "birthPlaceOf"
    let black = _prefixId.prefix "black"
    let blackAnti_Oppression = _prefixId.prefix "blackAnti-Oppression"
    let blackEthnicity = _prefixId.prefix "blackEthnicity"
    let blackLabel = _prefixId.prefix "blackLabel"
    let blackNationalism = _prefixId.prefix "blackNationalism"
    let blackRaceColour = _prefixId.prefix "blackRaceColour"
    let blackWomanRaceColour = _prefixId.prefix "blackWomanRaceColour"
    let blacksmith = _prefixId.prefix "blacksmith"
    let bloodRelativeOf = _prefixId.prefix "bloodRelativeOf"
    let boardMember = _prefixId.prefix "boardMember"
    let boardingHouseKeeper = _prefixId.prefix "boardingHouseKeeper"
    let bohemianism = _prefixId.prefix "bohemianism"
    let bolshevism = _prefixId.prefix "bolshevism"
    let bonapartism = _prefixId.prefix "bonapartism"
    let bookProduction = _prefixId.prefix "bookProduction"
    let bookbinder = _prefixId.prefix "bookbinder"
    let bookclubParticipatant = _prefixId.prefix "bookclubParticipatant"
    let botanist = _prefixId.prefix "botanist"
    let boulangism = _prefixId.prefix "boulangism"
    let brahmin = _prefixId.prefix "brahmin"
    let brewer = _prefixId.prefix "brewer"
    let britishNationalIdentity = _prefixId.prefix "britishNationalIdentity"
    let britishNationalism = _prefixId.prefix "britishNationalism"
    let broadcasting = _prefixId.prefix "broadcasting"
    /// <summary>
    ///   <para>rdfs:label : frère derdfs:label : brother of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#brotherOf">cwrc:brotherOf</a>
    /// </summary>
    let brotherOf = _prefixId.prefix "brotherOf"
    let buddhism = _prefixId.prefix "buddhism"
    let bullionCarrier = _prefixId.prefix "bullionCarrier"
    /// <summary>
    ///   <para>rdfs:label : burial place ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#burialPlaceOf">cwrc:burialPlaceOf</a>
    /// </summary>
    let burialPlaceOf = _prefixId.prefix "burialPlaceOf"
    let bursar = _prefixId.prefix "bursar"
    let bushido = _prefixId.prefix "bushido"
    let business = _prefixId.prefix "business"
    let businessOwner = _prefixId.prefix "businessOwner"
    let butcher = _prefixId.prefix "butcher"

    let c1583789_0dad_41d3_8a42_94d7a8e6d451 = _prefixId.prefix "c1583789-0dad-41d3-8a42-94d7a8e6d451"

    let c3a52178_f054_494c_9afd_7421ddcb384a = _prefixId.prefix "c3a52178-f054-494c-9afd-7421ddcb384a"

    let c3a52178_f054_494c_9afd_7421ddcb384a_215ee9c7d9 = _prefixId.prefix "c3a52178-f054-494c-9afd-7421ddcb384a-215ee9c7d9"

    let c3a52178_f054_494c_9afd_7421ddcb384a_partof = _prefixId.prefix "c3a52178-f054-494c-9afd-7421ddcb384a-partof"

    let c5e7bace_95bb_4820_bd7d_6bb97c1badc5 = _prefixId.prefix "c5e7bace-95bb-4820-bd7d-6bb97c1badc5"

    let c6a678e5_8fc6_41bc_8631_7cfb7116017e = _prefixId.prefix "c6a678e5-8fc6-41bc-8631-7cfb7116017e"

    let c6a678e5_8fc6_41bc_8631_7cfb7116017e_215ee9c7d9 = _prefixId.prefix "c6a678e5-8fc6-41bc-8631-7cfb7116017e-215ee9c7d9"

    let c6a678e5_8fc6_41bc_8631_7cfb7116017e_5c65118109 = _prefixId.prefix "c6a678e5-8fc6-41bc-8631-7cfb7116017e-5c65118109"

    let c7fcb056_415f_4700_8a9b_d228c9b969fe = _prefixId.prefix "c7fcb056-415f-4700-8a9b-d228c9b969fe"

    let c7fcb056_415f_4700_8a9b_d228c9b969fe_215ee9c7d9 = _prefixId.prefix "c7fcb056-415f-4700-8a9b-d228c9b969fe-215ee9c7d9"

    let c7fcb056_415f_4700_8a9b_d228c9b969fe_partof = _prefixId.prefix "c7fcb056-415f-4700-8a9b-d228c9b969fe-partof"

    let c7fcb056_415f_4700_8a9b_d228c9b969fe_partof_8b553ee329 = _prefixId.prefix "c7fcb056-415f-4700-8a9b-d228c9b969fe-partof-8b553ee329"

    let c808aed0_eb7b_4c84_9863_63da43401f8e = _prefixId.prefix "c808aed0-eb7b-4c84-9863-63da43401f8e"

    let c808aed0_eb7b_4c84_9863_63da43401f8e_0204e54c05 = _prefixId.prefix "c808aed0-eb7b-4c84-9863-63da43401f8e-0204e54c05"

    let c808aed0_eb7b_4c84_9863_63da43401f8e_d76b887762 = _prefixId.prefix "c808aed0-eb7b-4c84-9863-63da43401f8e-d76b887762"

    let calligraphy = _prefixId.prefix "calligraphy"
    let calvinism = _prefixId.prefix "calvinism"
    let camisards = _prefixId.prefix "camisards"
    let capitalism = _prefixId.prefix "capitalism"
    let captain = _prefixId.prefix "captain"
    let careGiver = _prefixId.prefix "careGiver"
    let cartesianism = _prefixId.prefix "cartesianism"
    let cartoonist = _prefixId.prefix "cartoonist"
    let catering = _prefixId.prefix "catering"
    let catholicChurch = _prefixId.prefix "catholicChurch"
    let catholicEmancipation = _prefixId.prefix "catholicEmancipation"
    let catholicism = _prefixId.prefix "catholicism"
    let celticEthnicity = _prefixId.prefix "celticEthnicity"
    let censor = _prefixId.prefix "censor"
    /// <summary>
    ///   <para>skos:definition : Links a level of &lt;a href="#Certainty" title="#Certainty"&gt;certainty&lt;/a&gt; to a sourceskos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : certainty of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#certaintyOf">cwrc:certaintyOf</a>
    /// </summary>
    let certaintyOf = _prefixId.prefix "certaintyOf"
    let certificate = _prefixId.prefix "certificate"
    let chairperson = _prefixId.prefix "chairperson"
    let chaperone = _prefixId.prefix "chaperone"
    let charityWorker = _prefixId.prefix "charityWorker"
    let chartism = _prefixId.prefix "chartism"
    let chemist = _prefixId.prefix "chemist"
    let chess = _prefixId.prefix "chess"
    /// <summary>
    ///   <para>rdfs:label : enfant derdfs:label : child of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#childOf">cwrc:childOf</a>
    /// </summary>
    let childOf = _prefixId.prefix "childOf"
    let childcare = _prefixId.prefix "childcare"
    let childcareWork = _prefixId.prefix "childcareWork"
    let childlessness = _prefixId.prefix "childlessness"
    let childrensWelfare = _prefixId.prefix "childrensWelfare"
    let chineseEthnicity = _prefixId.prefix "chineseEthnicity"
    let christianPacifism = _prefixId.prefix "christianPacifism"
    let christianScience = _prefixId.prefix "christianScience"
    let christianSocialism = _prefixId.prefix "christianSocialism"
    let christianity = _prefixId.prefix "christianity"
    let churchOfChristianScience = _prefixId.prefix "churchOfChristianScience"
    let churchOfEngland = _prefixId.prefix "churchOfEngland"
    let churchOfIreland = _prefixId.prefix "churchOfIreland"
    let cisGender = _prefixId.prefix "cisGender"
    let cisMan = _prefixId.prefix "cisMan"
    let cisWoman = _prefixId.prefix "cisWoman"
    let civilLibertarianism = _prefixId.prefix "civilLibertarianism"
    let civilRights = _prefixId.prefix "civilRights"
    let classicist = _prefixId.prefix "classicist"
    let cleaner = _prefixId.prefix "cleaner"
    let clericalWork = _prefixId.prefix "clericalWork"
    let clothingProduction = _prefixId.prefix "clothingProduction"
    let clothworker = _prefixId.prefix "clothworker"
    let co_operativeMovement = _prefixId.prefix "co-operativeMovement"
    let coach = _prefixId.prefix "coach"
    let coastGuard = _prefixId.prefix "coastGuard"
    let cobbler = _prefixId.prefix "cobbler"
    let collector = _prefixId.prefix "collector"
    let colonialOfficial = _prefixId.prefix "colonialOfficial"
    let commissioner = _prefixId.prefix "commissioner"
    let committeeMember = _prefixId.prefix "committeeMember"
    let communalism = _prefixId.prefix "communalism"
    let communeOrganizer = _prefixId.prefix "communeOrganizer"
    let communism = _prefixId.prefix "communism"
    let companion = _prefixId.prefix "companion"
    let composer = _prefixId.prefix "composer"
    let computerScientist = _prefixId.prefix "computerScientist"
    let computerWork = _prefixId.prefix "computerWork"
    let confectioner = _prefixId.prefix "confectioner"
    let congregationalChurch = _prefixId.prefix "congregationalChurch"
    let congregationalism = _prefixId.prefix "congregationalism"
    let connoisseur = _prefixId.prefix "connoisseur"
    let conscientiousObjection = _prefixId.prefix "conscientiousObjection"
    let conservationist = _prefixId.prefix "conservationist"
    let conservatism = _prefixId.prefix "conservatism"
    let conservativeFeminism = _prefixId.prefix "conservativeFeminism"
    let conservativePartyUk = _prefixId.prefix "conservativePartyUk"
    let constitutionalism = _prefixId.prefix "constitutionalism"
    let construction = _prefixId.prefix "construction"
    let consultant = _prefixId.prefix "consultant"
    let contractor = _prefixId.prefix "contractor"
    /// <summary>
    ///   <para>rdfs:label : contrary tordfs:label : contraire à</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#contraryTo">cwrc:contraryTo</a>
    /// </summary>
    let contraryTo = _prefixId.prefix "contraryTo"
    let cooking = _prefixId.prefix "cooking"
    let coopOrganizer = _prefixId.prefix "coopOrganizer"
    let cooper = _prefixId.prefix "cooper"
    let copyist = _prefixId.prefix "copyist"
    let cornishNationalHeritage = _prefixId.prefix "cornishNationalHeritage"
    let corporateDirector = _prefixId.prefix "corporateDirector"
    let counsellor = _prefixId.prefix "counsellor"
    let courtier = _prefixId.prefix "courtier"
    /// <summary>
    ///   <para>rdfs:label : cousin ofrdfs:label : cousin de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#cousinOf">cwrc:cousinOf</a>
    /// </summary>
    let cousinOf = _prefixId.prefix "cousinOf"
    let covenanters = _prefixId.prefix "covenanters"
    let craftsperson = _prefixId.prefix "craftsperson"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : credential held by</para>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#credentialHeldBy">cwrc:credentialHeldBy</a>
    /// </summary>
    let credentialHeldBy = _prefixId.prefix "credentialHeldBy"
    /// <summary>
    ///   <para>rdfs:label : credential subject ofrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#credentialSubjectOf">cwrc:credentialSubjectOf</a>
    /// </summary>
    let credentialSubjectOf = _prefixId.prefix "credentialSubjectOf"
    let creoleEthnicity = _prefixId.prefix "creoleEthnicity"
    let creoleRaceColour = _prefixId.prefix "creoleRaceColour"
    let cricket = _prefixId.prefix "cricket"
    let criminal = _prefixId.prefix "criminal"
    let critic = _prefixId.prefix "critic"
    /// <summary>
    ///   <para>skos:definition : This is the inverse of &lt;a href="#hasCulturalForm" title="#hasCulturalForm"&gt;has a cultural form&lt;/a&gt;.</para>
    ///   <para>rdfs:label : cultural form of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#culturalFormOf">cwrc:culturalFormOf</a>
    /// </summary>
    let culturalFormOf = _prefixId.prefix "culturalFormOf"
    let curator = _prefixId.prefix "curator"
    let cwrc = _prefixId.prefix "cwrc"
    let cyclist = _prefixId.prefix "cyclist"

    let d53c6644_df5c_43d7_86d3_2954c0d5a656 = _prefixId.prefix "d53c6644-df5c-43d7-86d3-2954c0d5a656"

    let d53c6644_df5c_43d7_86d3_2954c0d5a656_cb4c10a176 = _prefixId.prefix "d53c6644-df5c-43d7-86d3-2954c0d5a656-cb4c10a176"

    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7 = _prefixId.prefix "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7"

    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_42d9d30d94 = _prefixId.prefix "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-42d9d30d94"

    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_706552b3f4 = _prefixId.prefix "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-706552b3f4"

    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_cf7aa6a7bf = _prefixId.prefix "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-cf7aa6a7bf"

    let d596c4a0_ecaf_4739_8a58_3e0af7dba4c7_e523623174 = _prefixId.prefix "d596c4a0-ecaf-4739-8a58-3e0af7dba4c7-e523623174"

    let d95dce89_623d_4226_afd5_c602db0b6c7f = _prefixId.prefix "d95dce89-623d-4226-afd5-c602db0b6c7f"

    let d95dce89_623d_4226_afd5_c602db0b6c7f_215ee9c7d9 = _prefixId.prefix "d95dce89-623d-4226-afd5-c602db0b6c7f-215ee9c7d9"

    let d95dce89_623d_4226_afd5_c602db0b6c7f_partof = _prefixId.prefix "d95dce89-623d-4226-afd5-c602db0b6c7f-partof"

    let dairyWork = _prefixId.prefix "dairyWork"
    let dance = _prefixId.prefix "dance"
    let darwinism = _prefixId.prefix "darwinism"
    let dataProcessing = _prefixId.prefix "dataProcessing"
    let datasetdefinition = _prefixId.prefix "datasetdefinition"
    /// <summary>
    ///   <para>rdfs:label : daughter ofrdfs:label : fille de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#daughterOf">cwrc:daughterOf</a>
    /// </summary>
    let daughterOf = _prefixId.prefix "daughterOf"

    let db2f8571_a773_4068_a35f_34262950bb8f = _prefixId.prefix "db2f8571-a773-4068-a35f-34262950bb8f"

    let db2f8571_a773_4068_a35f_34262950bb8f_9841babf77 = _prefixId.prefix "db2f8571-a773-4068-a35f-34262950bb8f-9841babf77"

    let db3de175_7d4a_4860_908b_a905b9cc9b07 = _prefixId.prefix "db3de175-7d4a-4860-908b-a905b9cc9b07"

    let db3de175_7d4a_4860_908b_a905b9cc9b07_84fe24be76 = _prefixId.prefix "db3de175-7d4a-4860-908b-a905b9cc9b07-84fe24be76"

    let db3de175_7d4a_4860_908b_a905b9cc9b07_9eccf82c6d = _prefixId.prefix "db3de175-7d4a-4860-908b-a905b9cc9b07-9eccf82c6d"

    /// <summary>
    ///   <para>rdfs:label : death date ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#deathDateOf">cwrc:deathDateOf</a>
    /// </summary>
    let deathDateOf = _prefixId.prefix "deathDateOf"
    /// <summary>
    ///   <para>rdfs:label : death place ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#deathPlaceOf">cwrc:deathPlaceOf</a>
    /// </summary>
    let deathPlaceOf = _prefixId.prefix "deathPlaceOf"
    let decoder = _prefixId.prefix "decoder"
    let deism = _prefixId.prefix "deism"
    let deliveryPerson = _prefixId.prefix "deliveryPerson"
    let democrat = _prefixId.prefix "democrat"
    let dentist = _prefixId.prefix "dentist"
    let designer = _prefixId.prefix "designer"
    let determinism = _prefixId.prefix "determinism"

    let df029fed_c7f8_4438_97a4_33d9ff712cad = _prefixId.prefix "df029fed-c7f8-4438-97a4-33d9ff712cad"

    let df029fed_c7f8_4438_97a4_33d9ff712cad_63a2ae33d9 = _prefixId.prefix "df029fed-c7f8-4438-97a4-33d9ff712cad-63a2ae33d9"

    let df029fed_c7f8_4438_97a4_33d9ff712cad_b531d0ad51 = _prefixId.prefix "df029fed-c7f8-4438-97a4-33d9ff712cad-b531d0ad51"

    let diploma = _prefixId.prefix "diploma"
    let diplomat = _prefixId.prefix "diplomat"
    let director = _prefixId.prefix "director"
    let disestablishmentarianism = _prefixId.prefix "disestablishmentarianism"
    let dissentProtestant = _prefixId.prefix "dissentProtestant"
    let dissenters = _prefixId.prefix "dissenters"
    let dissentingChristianity = _prefixId.prefix "dissentingChristianity"
    let dissentingChurches = _prefixId.prefix "dissentingChurches"
    let diver = _prefixId.prefix "diver"
    let dockyardWork = _prefixId.prefix "dockyardWork"
    let doctorOfPhilosophy = _prefixId.prefix "doctorOfPhilosophy"
    /// <summary>
    ///   <para>skos:definition : Specifies a particular class type that is acceptable to use for a relation's domainskos:definition : </para>
    ///   <para>rdfs:label : domain includesrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#domainIncludes">cwrc:domainIncludes</a>
    /// </summary>
    let domainIncludes = _prefixId.prefix "domainIncludes"
    let domesticServant = _prefixId.prefix "domesticServant"
    let domesticWork = _prefixId.prefix "domesticWork"
    let dominicanOrder = _prefixId.prefix "dominicanOrder"
    let draper = _prefixId.prefix "draper"
    let dressReform = _prefixId.prefix "dressReform"
    let dressmaking = _prefixId.prefix "dressmaking"
    let dreyfusard = _prefixId.prefix "dreyfusard"
    let drinking = _prefixId.prefix "drinking"
    let drugUse = _prefixId.prefix "drugUse"
    let dutchNationalHeritage = _prefixId.prefix "dutchNationalHeritage"

    let e053e9f1_37ea_407d_b0cd_caaf413c142e = _prefixId.prefix "e053e9f1-37ea-407d-b0cd-caaf413c142e"

    let e053e9f1_37ea_407d_b0cd_caaf413c142e_63a2ae33d9 = _prefixId.prefix "e053e9f1-37ea-407d-b0cd-caaf413c142e-63a2ae33d9"

    let e053e9f1_37ea_407d_b0cd_caaf413c142e_a521eafbdd = _prefixId.prefix "e053e9f1-37ea-407d-b0cd-caaf413c142e-a521eafbdd"

    let e1f710d3_6ebd_4181_be61_bf931282a8b7 = _prefixId.prefix "e1f710d3-6ebd-4181-be61-bf931282a8b7"

    let e1f710d3_6ebd_4181_be61_bf931282a8b7_215ee9c7d9 = _prefixId.prefix "e1f710d3-6ebd-4181-be61-bf931282a8b7-215ee9c7d9"

    let e1f710d3_6ebd_4181_be61_bf931282a8b7_47d7a4164e = _prefixId.prefix "e1f710d3-6ebd-4181-be61-bf931282a8b7-47d7a4164e"

    let e2c7e804_1fa1_4575_b2a1_bf284412e036 = _prefixId.prefix "e2c7e804-1fa1-4575-b2a1-bf284412e036"

    let e2c7e804_1fa1_4575_b2a1_bf284412e036_a1a376d816 = _prefixId.prefix "e2c7e804-1fa1-4575-b2a1-bf284412e036-a1a376d816"

    let e2c7e804_1fa1_4575_b2a1_bf284412e036_d0d3bac526 = _prefixId.prefix "e2c7e804-1fa1-4575-b2a1-bf284412e036-d0d3bac526"

    let ea282bf0_da27_4ecc_98bd_e1aff595fc07 = _prefixId.prefix "ea282bf0-da27-4ecc-98bd-e1aff595fc07"

    let ea282bf0_da27_4ecc_98bd_e1aff595fc07_a70e175b3d = _prefixId.prefix "ea282bf0-da27-4ecc-98bd-e1aff595fc07-a70e175b3d"

    let ea282bf0_da27_4ecc_98bd_e1aff595fc07_a73943684a = _prefixId.prefix "ea282bf0-da27-4ecc-98bd-e1aff595fc07-a73943684a"

    let easternReligions = _prefixId.prefix "easternReligions"

    let ebbb5e23_2c34_4810_b921_1d72694af314 = _prefixId.prefix "ebbb5e23-2c34-4810-b921-1d72694af314"

    let ebbb5e23_2c34_4810_b921_1d72694af314_225e6db077 = _prefixId.prefix "ebbb5e23-2c34-4810-b921-1d72694af314-225e6db077"

    let ebbb5e23_2c34_4810_b921_1d72694af314_d5a62f9799 = _prefixId.prefix "ebbb5e23-2c34-4810-b921-1d72694af314-d5a62f9799"

    let ebbb5e23_2c34_4810_b921_1d72694af314_fb3b58e90b = _prefixId.prefix "ebbb5e23-2c34-4810-b921-1d72694af314-fb3b58e90b"

    let ebbb5e23_2c34_4810_b921_1d72694af314_partof = _prefixId.prefix "ebbb5e23-2c34-4810-b921-1d72694af314-partof"

    let ebbb5e23_2c34_4810_b921_1d72694af314_partof_33254c3df4 = _prefixId.prefix "ebbb5e23-2c34-4810-b921-1d72694af314-partof-33254c3df4"

    let ebbbc6b3_1f7b_4b8d_8eb2_003fafec3470 = _prefixId.prefix "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470"

    let ebbbc6b3_1f7b_4b8d_8eb2_003fafec3470_803d6baa7c = _prefixId.prefix "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-803d6baa7c"

    let ebbbc6b3_1f7b_4b8d_8eb2_003fafec3470_a76289714f = _prefixId.prefix "ebbbc6b3-1f7b-4b8d-8eb2-003fafec3470-a76289714f"

    let ecumenism = _prefixId.prefix "ecumenism"
    let editing = _prefixId.prefix "editing"
    let education = _prefixId.prefix "education"
    let educationReform = _prefixId.prefix "educationReform"
    let educationalAdministration = _prefixId.prefix "educationalAdministration"
    let educationalAwardPrize = _prefixId.prefix "educationalAwardPrize"
    let educationalAwardScholarship = _prefixId.prefix "educationalAwardScholarship"
    let egalitarianism = _prefixId.prefix "egalitarianism"
    let egyptianNationalism = _prefixId.prefix "egyptianNationalism"
    let elderRights = _prefixId.prefix "elderRights"
    let eldestChild = _prefixId.prefix "eldestChild"
    let elevatorOperator = _prefixId.prefix "elevatorOperator"
    let elocutionist = _prefixId.prefix "elocutionist"
    let employer = _prefixId.prefix "employer"
    let employmentAgent = _prefixId.prefix "employmentAgent"
    let engineering = _prefixId.prefix "engineering"
    let england = _prefixId.prefix "england"
    let englandLabel = _prefixId.prefix "englandLabel"
    let englishEthnicity = _prefixId.prefix "englishEthnicity"
    let englishGeographicHeritage = _prefixId.prefix "englishGeographicHeritage"
    let englishLabel = _prefixId.prefix "englishLabel"
    let englishNationalHeritage = _prefixId.prefix "englishNationalHeritage"
    let englishNationalIdentity = _prefixId.prefix "englishNationalIdentity"
    let englishRaceColour = _prefixId.prefix "englishRaceColour"
    let engraver = _prefixId.prefix "engraver"
    let entrepreneurial_industrialism = _prefixId.prefix "entrepreneurial-industrialism"
    let entrepreneurial_industrialist = _prefixId.prefix "entrepreneurial-industrialist"
    let environmentalism = _prefixId.prefix "environmentalism"
    let equineActivity = _prefixId.prefix "equineActivity"
    /// <summary>
    ///   <para>rdfs:label : ethnic identity ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicityOf">cwrc:ethnicityOf</a>
    /// </summary>
    let ethnicityOf = _prefixId.prefix "ethnicityOf"
    /// <summary>
    ///   <para>rdfs:label : ethnic identity (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicityReportedOf">cwrc:ethnicityReportedOf</a>
    /// </summary>
    let ethnicityReportedOf = _prefixId.prefix "ethnicityReportedOf"
    /// <summary>
    ///   <para>rdfs:label : ethnic identity (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#ethnicitySelfReportedOf">cwrc:ethnicitySelfReportedOf</a>
    /// </summary>
    let ethnicitySelfReportedOf = _prefixId.prefix "ethnicitySelfReportedOf"
    let eugenics = _prefixId.prefix "eugenics"
    let eurasianLabel = _prefixId.prefix "eurasianLabel"
    let eurasianRace = _prefixId.prefix "eurasianRace"
    let eurasianRaceColour = _prefixId.prefix "eurasianRaceColour"
    let europeanEthnicity = _prefixId.prefix "europeanEthnicity"
    let europeanNationalHeritage = _prefixId.prefix "europeanNationalHeritage"
    let europeanNationalIdentity = _prefixId.prefix "europeanNationalIdentity"
    let evangelicalism = _prefixId.prefix "evangelicalism"
    /// <summary>
    ///   <para>skos:definition : Associates an event with a subject or an event with another event.</para>
    ///   <para>rdfs:label : event ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#eventOf">cwrc:eventOf</a>
    /// </summary>
    let eventOf = _prefixId.prefix "eventOf"
    let eventOrganizer = _prefixId.prefix "eventOrganizer"
    let exhibitions = _prefixId.prefix "exhibitions"
    let existentialism = _prefixId.prefix "existentialism"
    let explorer = _prefixId.prefix "explorer"

    let f3666ac1_4f95_4f12_a02e_88ed27197d35 = _prefixId.prefix "f3666ac1-4f95-4f12-a02e-88ed27197d35"

    let f3666ac1_4f95_4f12_a02e_88ed27197d35_212cf56127 = _prefixId.prefix "f3666ac1-4f95-4f12-a02e-88ed27197d35-212cf56127"

    let f3666ac1_4f95_4f12_a02e_88ed27197d35_2eb3e2ce3d = _prefixId.prefix "f3666ac1-4f95-4f12-a02e-88ed27197d35-2eb3e2ce3d"

    let f3666ac1_4f95_4f12_a02e_88ed27197d35_8066d74e86 = _prefixId.prefix "f3666ac1-4f95-4f12-a02e-88ed27197d35-8066d74e86"

    let f62e94d6_bd04_494c_9282_53af0a3f3376 = _prefixId.prefix "f62e94d6-bd04-494c-9282-53af0a3f3376"

    let f62e94d6_bd04_494c_9282_53af0a3f3376_f16cfae794 = _prefixId.prefix "f62e94d6-bd04-494c-9282-53af0a3f3376-f16cfae794"

    let f62e94d6_bd04_494c_9282_53af0a3f3376_partof = _prefixId.prefix "f62e94d6-bd04-494c-9282-53af0a3f3376-partof"

    let f77171be_f937_4067_8dbe_fd9982822a96 = _prefixId.prefix "f77171be-f937-4067-8dbe-fd9982822a96"

    let f77171be_f937_4067_8dbe_fd9982822a96_e9e89595ea = _prefixId.prefix "f77171be-f937-4067-8dbe-fd9982822a96-e9e89595ea"

    let f77171be_f937_4067_8dbe_fd9982822a96_fd4dbf406b = _prefixId.prefix "f77171be-f937-4067-8dbe-fd9982822a96-fd4dbf406b"

    let fab56e35_9796_4e6d_861d_a6b626f5714d = _prefixId.prefix "fab56e35-9796-4e6d-861d-a6b626f5714d"

    let fab56e35_9796_4e6d_861d_a6b626f5714d_9871ba1d86 = _prefixId.prefix "fab56e35-9796-4e6d-861d-a6b626f5714d-9871ba1d86"

    let fab56e35_9796_4e6d_861d_a6b626f5714d_partof = _prefixId.prefix "fab56e35-9796-4e6d-861d-a6b626f5714d-partof"

    let fab56e35_9796_4e6d_861d_a6b626f5714d_partof_1dda925352 = _prefixId.prefix "fab56e35-9796-4e6d-861d-a6b626f5714d-partof-1dda925352"

    let fab56e35_9796_4e6d_861d_a6b626f5714d_partof_534915cfcc = _prefixId.prefix "fab56e35-9796-4e6d-861d-a6b626f5714d-partof-534915cfcc"

    let factoryWorker = _prefixId.prefix "factoryWorker"
    let faithHealing = _prefixId.prefix "faithHealing"
    /// <summary>
    ///   <para>rdfs:label : family-based occupation ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#familyBasedOccupationOf">cwrc:familyBasedOccupationOf</a>
    /// </summary>
    let familyBasedOccupationOf = _prefixId.prefix "familyBasedOccupationOf"
    let farming = _prefixId.prefix "farming"
    let fascism = _prefixId.prefix "fascism"
    let fashion = _prefixId.prefix "fashion"
    let fatalism = _prefixId.prefix "fatalism"
    /// <summary>
    ///   <para>rdfs:label : père derdfs:label : father of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#fatherOf">cwrc:fatherOf</a>
    /// </summary>
    let fatherOf = _prefixId.prefix "fatherOf"
    let fellow = _prefixId.prefix "fellow"
    let femaleSex = _prefixId.prefix "femaleSex"
    let feminism = _prefixId.prefix "feminism"
    let feministAnti_ViolenceActivism = _prefixId.prefix "feministAnti-ViolenceActivism"
    let feministInternationalism = _prefixId.prefix "feministInternationalism"
    let feministPacifism = _prefixId.prefix "feministPacifism"

    let ffd10388_4cd6_429c_9ca0_b4d9476496a1 = _prefixId.prefix "ffd10388-4cd6-429c-9ca0-b4d9476496a1"

    let ffd10388_4cd6_429c_9ca0_b4d9476496a1_16ff462e2c = _prefixId.prefix "ffd10388-4cd6-429c-9ca0-b4d9476496a1-16ff462e2c"

    let ffd10388_4cd6_429c_9ca0_b4d9476496a1_e7a6810311 = _prefixId.prefix "ffd10388-4cd6-429c-9ca0-b4d9476496a1-e7a6810311"

    let fifthMonarchists = _prefixId.prefix "fifthMonarchists"
    let filmIndustry = _prefixId.prefix "filmIndustry"
    let finance = _prefixId.prefix "finance"
    let firefighter = _prefixId.prefix "firefighter"
    let firstAid = _prefixId.prefix "firstAid"
    let fisherman = _prefixId.prefix "fisherman"
    let fishmonger = _prefixId.prefix "fishmonger"
    let flemishNationalHeritage = _prefixId.prefix "flemishNationalHeritage"
    let florentineNationalIdentity = _prefixId.prefix "florentineNationalIdentity"
    let foodDistribution = _prefixId.prefix "foodDistribution"
    let forebearOf = _prefixId.prefix "forebearOf"
    let fosterParent = _prefixId.prefix "fosterParent"
    let founder = _prefixId.prefix "founder"
    let freeTradeMovement = _prefixId.prefix "freeTradeMovement"
    let freemasonry = _prefixId.prefix "freemasonry"
    let freethought = _prefixId.prefix "freethought"
    let frenchNationalism = _prefixId.prefix "frenchNationalism"
    let fundraiser = _prefixId.prefix "fundraiser"
    let gaelEthnicity = _prefixId.prefix "gaelEthnicity"
    let gambling = _prefixId.prefix "gambling"
    let gardener = _prefixId.prefix "gardener"
    let gastronome = _prefixId.prefix "gastronome"
    let gayRights = _prefixId.prefix "gayRights"
    let genderManMale = _prefixId.prefix "genderManMale"
    /// <summary>
    ///   <para>rdfs:label : gender identity ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#genderOf">cwrc:genderOf</a>
    /// </summary>
    let genderOf = _prefixId.prefix "genderOf"
    /// <summary>
    ///   <para>rdfs:label : gender identity (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#genderReportedOf">cwrc:genderReportedOf</a>
    /// </summary>
    let genderReportedOf = _prefixId.prefix "genderReportedOf"
    /// <summary>
    ///   <para>rdfs:label : gender identity (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#genderSelfReportedOf">cwrc:genderSelfReportedOf</a>
    /// </summary>
    let genderSelfReportedOf = _prefixId.prefix "genderSelfReportedOf"
    let genderTransMan = _prefixId.prefix "genderTransMan"
    let genderTransWoman = _prefixId.prefix "genderTransWoman"
    let genderWomanFemale = _prefixId.prefix "genderWomanFemale"
    let genealogist = _prefixId.prefix "genealogist"
    let gentleman = _prefixId.prefix "gentleman"
    let gentry = _prefixId.prefix "gentry"
    let geographer = _prefixId.prefix "geographer"
    /// <summary>
    ///   <para>rdfs:label : geographic heritage ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageOf">cwrc:geographicHeritageOf</a>
    /// </summary>
    let geographicHeritageOf = _prefixId.prefix "geographicHeritageOf"
    /// <summary>
    ///   <para>rdfs:label : geographic heritage (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageReportedOf">cwrc:geographicHeritageReportedOf</a>
    /// </summary>
    let geographicHeritageReportedOf = _prefixId.prefix "geographicHeritageReportedOf"

    /// <summary>
    ///   <para>rdfs:label : geographic heritage (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#geographicHeritageSelfReportedOf">cwrc:geographicHeritageSelfReportedOf</a>
    /// </summary>
    let geographicHeritageSelfReportedOf = _prefixId.prefix "geographicHeritageSelfReportedOf"

    let geologist = _prefixId.prefix "geologist"
    let germanNationalism = _prefixId.prefix "germanNationalism"
    let girondin = _prefixId.prefix "girondin"
    let glassWorker = _prefixId.prefix "glassWorker"
    let glover = _prefixId.prefix "glover"
    let gnosticism = _prefixId.prefix "gnosticism"
    let goldsmith = _prefixId.prefix "goldsmith"
    let governess = _prefixId.prefix "governess"
    let government = _prefixId.prefix "government"
    let governmentOfficial = _prefixId.prefix "governmentOfficial"
    let governorGeneral = _prefixId.prefix "governorGeneral"
    /// <summary>
    ///   <para>rdfs:label : petit enfant derdfs:label : grandchild of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#grandChildOf">cwrc:grandChildOf</a>
    /// </summary>
    let grandChildOf = _prefixId.prefix "grandChildOf"
    /// <summary>
    ///   <para>rdfs:label : petite fille derdfs:label : granddaughter of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#grandDaughterOf">cwrc:grandDaughterOf</a>
    /// </summary>
    let grandDaughterOf = _prefixId.prefix "grandDaughterOf"
    /// <summary>
    ///   <para>rdfs:label : grandfather ofrdfs:label : grand-père de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#grandFatherOf">cwrc:grandFatherOf</a>
    /// </summary>
    let grandFatherOf = _prefixId.prefix "grandFatherOf"
    /// <summary>
    ///   <para>rdfs:label : grandmother ofrdfs:label : grand-mère de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#grandMotherOf">cwrc:grandMotherOf</a>
    /// </summary>
    let grandMotherOf = _prefixId.prefix "grandMotherOf"
    /// <summary>
    ///   <para>rdfs:label : grandparent derdfs:label : grandparent of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#grandParentOf">cwrc:grandParentOf</a>
    /// </summary>
    let grandParentOf = _prefixId.prefix "grandParentOf"
    /// <summary>
    ///   <para>rdfs:label : petit fils derdfs:label : grandson of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#grandSonOf">cwrc:grandSonOf</a>
    /// </summary>
    let grandSonOf = _prefixId.prefix "grandSonOf"
    let greekNationalist = _prefixId.prefix "greekNationalist"
    let grocer = _prefixId.prefix "grocer"
    let guardian = _prefixId.prefix "guardian"
    /// <summary>
    ///   <para>skos:definition : Une personne placé en charge du bienfait d'un personne mineure.skos:definition : </para>
    ///   <para>rdfs:label : tuteur (‑trice) / gardien (ne)rdfs:label : guardian of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#guardianOf">cwrc:guardianOf</a>
    /// </summary>
    let guardianOf = _prefixId.prefix "guardianOf"
    let guelphPartyFlorence = _prefixId.prefix "guelphPartyFlorence"
    let haberdasher = _prefixId.prefix "haberdasher"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : half-brother of</para>
    ///   <para>skos:note : Comment: This term is a CWRC-specific addition not in the original Orlando tag set.^^xsd:string</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#halfBrotherOf">cwrc:halfBrotherOf</a>
    /// </summary>
    let halfBrotherOf = _prefixId.prefix "halfBrotherOf"
    /// <summary>
    ///   <para>skos:note : Comment: This term is a CWRC-specific addition not in the original Orlando tag set.^^xsd:string</para>
    ///   <para>rdfs:label : rdfs:label : half-sister of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#halfSisterOf">cwrc:halfSisterOf</a>
    /// </summary>
    let halfSisterOf = _prefixId.prefix "halfSisterOf"
    let handwritingExpert = _prefixId.prefix "handwritingExpert"
    let hanoverian = _prefixId.prefix "hanoverian"
    let hanoverianNationalIdentity = _prefixId.prefix "hanoverianNationalIdentity"
    /// <summary>
    ///   <para>rdfs:label : has activist involvement fromrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementFrom">cwrc:hasActivistInvolvementFrom</a>
    /// </summary>
    let hasActivistInvolvementFrom = _prefixId.prefix "hasActivistInvolvementFrom"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Indicates the highest level of political involvement in a particular cause. It indicates such activities as suffragists chaining themselves to railings or women camping out at Greenham Common, as well as very active leadership roles in a political organization. Thus Josephine Butler, founder of the Ladies' National Association Against the Contagious Diseases Acts, qualifies as activist for having founded the organization, directed its activities, and for speaking publicly at meetings at considerable personal risk.</para>
    ///   <para>rdfs:label : rdfs:label : has activist involvement in</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasActivistInvolvementIn">cwrc:hasActivistInvolvementIn</a>
    /// </summary>
    let hasActivistInvolvementIn = _prefixId.prefix "hasActivistInvolvementIn"
    /// <summary>
    ///   <para>skos:altLabel : forebear</para>
    ///   <para>rdfs:label : rdfs:label : has ancestor</para>
    ///   <para>skos:definition : skos:definition : Relates a person to an ancestor or forebear, usually at a remove of two generations or more.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasAncestor">cwrc:hasAncestor</a>
    /// </summary>
    let hasAncestor = _prefixId.prefix "hasAncestor"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the sister of their father or mother, but can also refer to any maternal relationship and need not be restricted to a consanguineal relation.skos:definition : </para>
    ///   <para>rdfs:label : has auntrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasAunt">cwrc:hasAunt</a>
    /// </summary>
    let hasAunt = _prefixId.prefix "hasAunt"
    /// <summary>
    ///   <para>skos:definition : Indique une récompense, un prix ou une distinction qu'une personne a gagné, tel qu'un prix littéraire ou un prix d'éducation.skos:definition : Indicates an award, prize, or recognition that a person has won, such as a literary award or an &lt;a href="#educationalAwardPrize" title="#educationalAwardPrize"&gt;educational award prize&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has awardrdfs:label : a une récompense</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasAward">cwrc:hasAward</a>
    /// </summary>
    let hasAward = _prefixId.prefix "hasAward"
    /// <summary>
    ///   <para>skos:definition : Indicates the date of which a person was born.skos:definition : </para>
    ///   <para>rdfs:label : has birth daterdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthDate">cwrc:hasBirthDate</a>
    /// </summary>
    let hasBirthDate = _prefixId.prefix "hasBirthDate"
    /// <summary>
    ///   <para>skos:definition : Indicates where a person was born.skos:definition : </para>
    ///   <para>rdfs:label : has birth placerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPlace">cwrc:hasBirthPlace</a>
    /// </summary>
    let hasBirthPlace = _prefixId.prefix "hasBirthPlace"
    /// <summary>
    ///   <para>skos:definition : Indicates a person's &lt;a href="#BirthPosition" title="#BirthPosition"&gt;birth position&lt;/a&gt; relative to their siblings, with accompanying context provided by &lt;a href="#BirthContext" title="#BirthContext"&gt;birth context&lt;/a&gt; annotations.skos:definition : </para>
    ///   <para>rdfs:label : has birth positionrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasBirthPosition">cwrc:hasBirthPosition</a>
    /// </summary>
    let hasBirthPosition = _prefixId.prefix "hasBirthPosition"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a male-identified sibling. Although the term typically refers to consanguineal relationships, it is often used to describe relationships beyond "blood ties."skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has brother</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasBrother">cwrc:hasBrother</a>
    /// </summary>
    let hasBrother = _prefixId.prefix "hasBrother"
    /// <summary>
    ///   <para>skos:definition : Indicates where a person was buried after death.skos:definition : </para>
    ///   <para>rdfs:label : has burial placerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasBurialPlace">cwrc:hasBurialPlace</a>
    /// </summary>
    let hasBurialPlace = _prefixId.prefix "hasBurialPlace"
    /// <summary>
    ///   <para>skos:definition : Décrit le décès d'une personne.skos:definition : Describes a person's death.</para>
    ///   <para>rdfs:label : has cause of deathrdfs:label : a une cause de décès</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCauseOfDeath">cwrc:hasCauseOfDeath</a>
    /// </summary>
    let hasCauseOfDeath = _prefixId.prefix "hasCauseOfDeath"
    /// <summary>
    ///   <para>skos:definition : Associates a level of &lt;a href="#Certainty" title="#Certainty"&gt;certainty&lt;/a&gt; for a sourceskos:definition : </para>
    ///   <para>rdfs:label : has certaintyrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCertainty">cwrc:hasCertainty</a>
    /// </summary>
    let hasCertainty = _prefixId.prefix "hasCertainty"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a child, consanguineal or otherwise.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has child</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasChild">cwrc:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:label : has childrenrdfs:label : </para>
    ///   <para>skos:definition : Indicates the number of the subject's children. Values range from zero upwards, and modes of counting vary according to context because families and reproduction are complex matters. Children need not necessarily be biologically related to the subject: they may be adopted or otherwise considered a person's child. See related property &lt;a href="#hasReproductiveHistory" title="#hasReproductiveHistory"&gt;has reproductive history&lt;/a&gt;.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasChildren">cwrc:hasChildren</a>
    /// </summary>
    let hasChildren = _prefixId.prefix "hasChildren"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Describes a relationship of cohabitation which may or may not be an intimate or erotic relationship, since historical evidence with respect to the nature of such relationships is often lacking.</para>
    ///   <para>rdfs:label : has cohabitantrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCohabitant">cwrc:hasCohabitant</a>
    /// </summary>
    let hasCohabitant = _prefixId.prefix "hasCohabitant"
    /// <summary>
    ///   <para>skos:definition : Décrit la relation du sujet avec une personne, habituellement un·e camarade, dans le contexte de son éducation.skos:definition : Describes a relationship with a person, usually a peer, in the context of the subject's education.</para>
    ///   <para>rdfs:label : has companionrdfs:label : a un·e camarade</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCompanion">cwrc:hasCompanion</a>
    /// </summary>
    let hasCompanion = _prefixId.prefix "hasCompanion"
    /// <summary>
    ///   <para>skos:definition : Décrit le comportement, perçu comme négatif, dans le contexte de l'éducation du sujet. Souvent indicateur d'une lutte contre la discrimination systémique, y compris au sein des structures de l'éducation insitutionnelle.skos:definition : Describes behaviour, which is perceived as negative, in the context of the subject's education. Often indicative of struggle against systemic discrimination, including within the structures of educational institutions.</para>
    ///   <para>rdfs:label : has nonconformant behaviourrdfs:label : comportement contesté</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasContestedBehaviour">cwrc:hasContestedBehaviour</a>
    /// </summary>
    let hasContestedBehaviour = _prefixId.prefix "hasContestedBehaviour"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has cousin</para>
    ///   <para>skos:definition : skos:definition : Relates a person to the child of their aunt or uncle; a person belonging to the same extended family, consanguineal or otherwise.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCousin">cwrc:hasCousin</a>
    /// </summary>
    let hasCousin = _prefixId.prefix "hasCousin"
    /// <summary>
    ///   <para>skos:definition : Indicates an educational credential awarded to a person.skos:definition : </para>
    ///   <para>rdfs:label : has credential inrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialIn">cwrc:hasCredentialIn</a>
    /// </summary>
    let hasCredentialIn = _prefixId.prefix "hasCredentialIn"
    /// <summary>
    ///   <para>skos:definition : Indicates a subject in which a person has pursued or received a degree.skos:definition : </para>
    ///   <para>rdfs:label : has credential subjectrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCredentialSubject">cwrc:hasCredentialSubject</a>
    /// </summary>
    let hasCredentialSubject = _prefixId.prefix "hasCredentialSubject"
    /// <summary>
    ///   <para>skos:definition : This associates specific concepts and categories with the process of identity formation through cultural processes. Such associations may be or have been embraced by the subject her/himself or attributed by others. The concepts and categories classed as a &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt; are understood to overlap with each other conceptually and in terms of the labels used.skos:definition : Associe des concepts et des catégories spécifiques au processus de formation identitaire par des processus culturels. Les sujets eux-mêmes peuvent ou ont pu s'approprier de telles associations, ou d'autres personnes les leur ont attribuées. Les concepts et les catégories classés dans &lt;a href="#CulturalForm" title="#CulturalForm"&gt;forme culturelle&lt;/a&gt; se chevauchent pour les concepts et les étiquettes utilisés.</para>
    ///   <para>rdfs:label : has a cultural formrdfs:label : a une forme culturelle</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasCulturalForm">cwrc:hasCulturalForm</a>
    /// </summary>
    let hasCulturalForm = _prefixId.prefix "hasCulturalForm"
    let hasCulturalForms = _prefixId.prefix "hasCulturalForms"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has daughter</para>
    ///   <para>skos:definition : skos:definition : Relates a person to a female-identified child, consanguineal or otherwise.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasDaughter">cwrc:hasDaughter</a>
    /// </summary>
    let hasDaughter = _prefixId.prefix "hasDaughter"
    /// <summary>
    ///   <para>skos:definition : Indicates the date of which a person has died.skos:definition : </para>
    ///   <para>rdfs:label : has death daterdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasDeathDate">cwrc:hasDeathDate</a>
    /// </summary>
    let hasDeathDate = _prefixId.prefix "hasDeathDate"
    /// <summary>
    ///   <para>skos:definition : Indicates where a person has died.skos:definition : </para>
    ///   <para>rdfs:label : has death placerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasDeathPlace">cwrc:hasDeathPlace</a>
    /// </summary>
    let hasDeathPlace = _prefixId.prefix "hasDeathPlace"
    /// <summary>
    ///   <para>skos:definition : Relie une personne à des renseignements sur son contexte éducatif.skos:definition : Links a person to information about their education in &lt;a href="#EducationContext" title="#EducationContext"&gt;education context&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has educationrdfs:label : a une éducation</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEducation">cwrc:hasEducation</a>
    /// </summary>
    let hasEducation = _prefixId.prefix "hasEducation"
    let hasElement = _prefixId.prefix "hasElement"
    /// <summary>
    ///   <para>rdfs:label : has emigrantrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmigrant">cwrc:hasEmigrant</a>
    /// </summary>
    let hasEmigrant = _prefixId.prefix "hasEmigrant"
    /// <summary>
    ///   <para>rdfs:label : has employeerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmployee">cwrc:hasEmployee</a>
    /// </summary>
    let hasEmployee = _prefixId.prefix "hasEmployee"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Indicates a person's employer.</para>
    ///   <para>rdfs:label : rdfs:label : has employer</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEmployer">cwrc:hasEmployer</a>
    /// </summary>
    let hasEmployer = _prefixId.prefix "hasEmployer"
    /// <summary>
    ///   <para>skos:definition : Describes intimate relationships that are erotic and/or explicitly sexual. Erotic in this context sometimes suggests that sexuality was an issue in the relationship, whether or not it was acted upon. In not wishing to assume that heterosexual relations between sexual partners are the only standard for intimate relationships, we include both erotic and non-erotic relations as central to a subject’s life and use &lt;a href="#hasEroticRelationshipWith" title="#hasEroticRelationshipWith"&gt;has erotic relationship with&lt;/a&gt; to distinguish between the two. See &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;has interpersonal relationship with&lt;/a&gt;, &lt;a href="#hasEroticRelationshipWith" title="#hasEroticRelationshipWith"&gt;has erotic relationship with&lt;/a&gt;, &lt;a href="#hasIntimateRelationshipWith" title="#hasIntimateRelationshipWith"&gt;has intimate relationship with&lt;/a&gt;, &lt;a href="#hasPossiblyEroticRelationshipWith" title="#hasPossiblyEroticRelationshipWith"&gt;has possibly erotic relationship with&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has erotic relationship with</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEroticRelationshipWith">cwrc:hasEroticRelationshipWith</a>
    /// </summary>
    let hasEroticRelationshipWith = _prefixId.prefix "hasEroticRelationshipWith"
    /// <summary>
    ///   <para>skos:definition : Indicates a person's ethnic identity, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt;.skos:definition : Décrit l'ethnicité d'une personne. De même que pour les autres formes culturelles, une même personne peut cumuler plus d'une propriété ou description de ce type. Pour plus d'informations sur cette propriété, voir &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicité&lt;/a&gt;</para>
    ///   <para>rdfs:label : has ethnic identityrdfs:label : d'ethnicité</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicity">cwrc:hasEthnicity</a>
    /// </summary>
    let hasEthnicity = _prefixId.prefix "hasEthnicity"
    /// <summary>
    ///   <para>rdfs:label : d'ethnicité (déclarée)rdfs:label : has ethnic identity (reported)</para>
    ///   <para>skos:definition : Décrit l'ethnicité déclarée, accompagnée du contexte fourni par les annotations de &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; là ou il est disponible. Pour plus d'informations sur cette propriété, voir &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicité&lt;/a&gt;.skos:definition : Indicates a person's reported ethnic identity, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. For more information on this property, see &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicityReported">cwrc:hasEthnicityReported</a>
    /// </summary>
    let hasEthnicityReported = _prefixId.prefix "hasEthnicityReported"
    let hasEthnicitySelfDefined = _prefixId.prefix "hasEthnicitySelfDefined"
    /// <summary>
    ///   <para>skos:definition : Indicates a person's self-reported ethnic identity, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. For more information on this property, see &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicity&lt;/a&gt;.skos:definition : Décrit l'ethnicité autodéclarée, accompagnée du contexte fourni par les annotations de &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;contexte ethnique ou racial&lt;/a&gt; là ou il est disponible. Pour plus d'informations sur cette propriété, voir &lt;a href="#Ethnicity" title="#Ethnicity"&gt;ethnicité&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has ethnic identity (self-reported)rdfs:label : d'ethnicité (autodéclarée)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEthnicitySelfReported">cwrc:hasEthnicitySelfReported</a>
    /// </summary>
    let hasEthnicitySelfReported = _prefixId.prefix "hasEthnicitySelfReported"
    /// <summary>
    ///   <para>skos:definition : Associates a subject with an eventskos:definition : </para>
    ///   <para>rdfs:label : has eventrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasEvent">cwrc:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    let hasEventElement = _prefixId.prefix "hasEventElement"
    /// <summary>
    ///   <para>rdfs:label : has family-based occupationrdfs:label : </para>
    ///   <para>skos:definition : Indicates a position or activity that was family-directed, typically bread-winning businesses rather than domestic work although the two may overlap.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasFamilyBasedOccupation">cwrc:hasFamilyBasedOccupation</a>
    /// </summary>
    let hasFamilyBasedOccupation = _prefixId.prefix "hasFamilyBasedOccupation"
    /// <summary>
    ///   <para>skos:definition : Relates a person to their father, the male-identified parent, consanguineal or otherwise.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has father</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasFather">cwrc:hasFather</a>
    /// </summary>
    let hasFather = _prefixId.prefix "hasFather"
    /// <summary>
    ///   <para>skos:definition : Relates terms within the CWRC ontology to external terms that are semantically incommensurate but that may be pragmatically related for processing purposes such as search and retrieval. For example, the &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt; instance &lt;a href="#woman" title="#woman"&gt;woman&lt;/a&gt; relates functionally to appearances:SexISO5218-2 because important datasets employ the ISO5218 value "female". hasFunctionalRelation can be leveraged by search tools to broaden the results returned.skos:definition : </para>
    ///   <para>rdfs:label : has functional relationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasFunctionalRelation">cwrc:hasFunctionalRelation</a>
    /// </summary>
    let hasFunctionalRelation = _prefixId.prefix "hasFunctionalRelation"
    /// <summary>
    ///   <para>rdfs:label : est de genrerdfs:label : has gender identity</para>
    ///   <para>skos:definition : Describes a person's &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt; identity, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#GenderContext" title="#GenderContext"&gt;gender context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGender">cwrc:hasGender</a>
    /// </summary>
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Indicates a person's reported &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt; identity, with accompanying context, where present, provided by &lt;a href="#GenderContext" title="#GenderContext"&gt;gender context&lt;/a&gt; annotations.</para>
    ///   <para>rdfs:label : has gender identity (reported)rdfs:label : est de genre (déclaré)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderReported">cwrc:hasGenderReported</a>
    /// </summary>
    let hasGenderReported = _prefixId.prefix "hasGenderReported"
    let hasGenderSelfDeclared = _prefixId.prefix "hasGenderSelfDeclared"
    /// <summary>
    ///   <para>rdfs:label : has gender identity (self-reported)rdfs:label : est de genre (autodéclaré)</para>
    ///   <para>skos:definition : Cela indique le &lt;a href="#Gender" title="#Gender"&gt;genre&lt;/a&gt; autoproclamé d'une personne.skos:definition : Describes a person's self-reported &lt;a href="#Gender" title="#Gender"&gt;gender&lt;/a&gt; identity, with accompanying context, where present, provided by &lt;a href="#GenderContext" title="#GenderContext"&gt;gender context&lt;/a&gt; annotations.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderSelfReported">cwrc:hasGenderSelfReported</a>
    /// </summary>
    let hasGenderSelfReported = _prefixId.prefix "hasGenderSelfReported"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has gendered political activity</para>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivity">cwrc:hasGenderedPoliticalActivity</a>
    /// </summary>
    let hasGenderedPoliticalActivity = _prefixId.prefix "hasGenderedPoliticalActivity"

    /// <summary>
    ///   <para>rdfs:label : has gendered political activity fromrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGenderedPoliticalActivityFrom">cwrc:hasGenderedPoliticalActivityFrom</a>
    /// </summary>
    let hasGenderedPoliticalActivityFrom = _prefixId.prefix "hasGenderedPoliticalActivityFrom"

    /// <summary>
    ///   <para>skos:definition : Décrit l'héritage d'une personne en lien avec une situation géographique. Comme les toponomies et les frontières changent au cours du temps, une description de l'héritage géographique associée à une période historique donnée ne correspond pas toujours à celles des périodes antérieures ou postérieures, et ce même si elles possèdent le même nom. De même, le sentiment d'appartenance à un héritage géographique peut différer du sentiement d'appartenance à une entité politique du même nom. De même que pour les autres formes culturelles, une même personne peut cumuler plus d'une propriété ou description de ce type. Pour plus d'informations sur cette propriété, voir &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;héritage géographique&lt;/a&gt;.skos:definition : Describes a person's heritage in relation to a place, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. Place names and boundaries change over time, and a conception of geographical heritage from one historical period may not be commensurate with those from an earlier or later period, even if they go by the same name. Similarly, a sense of geographical heritage may differ from a sense of identity with a political entity that goes by the same name. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;.</para>
    ///   <para>rdfs:label : A un héritage géographiquerdfs:label : has geographic heritage</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritage">cwrc:hasGeographicHeritage</a>
    /// </summary>
    let hasGeographicHeritage = _prefixId.prefix "hasGeographicHeritage"
    /// <summary>
    ///   <para>skos:definition : Describes a person's reported &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations.skos:definition : </para>
    ///   <para>rdfs:label : a un héritage géographique (déclaré)rdfs:label : has geographic heritage (reported)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageReported">cwrc:hasGeographicHeritageReported</a>
    /// </summary>
    let hasGeographicHeritageReported = _prefixId.prefix "hasGeographicHeritageReported"

    let hasGeographicHeritageSelfDeclared = _prefixId.prefix "hasGeographicHeritageSelfDeclared"

    /// <summary>
    ///   <para>skos:definition : Describes a person's self-reported &lt;a href="#GeographicHeritage" title="#GeographicHeritage"&gt;geographic heritage&lt;/a&gt;, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations.skos:definition : </para>
    ///   <para>rdfs:label : a un héritage géographique (autodéclaré)rdfs:label : has geographic heritage (self-reported)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGeographicHeritageSelfReported">cwrc:hasGeographicHeritageSelfReported</a>
    /// </summary>
    let hasGeographicHeritageSelfReported = _prefixId.prefix "hasGeographicHeritageSelfReported"

    /// <summary>
    ///   <para>skos:definition : Relates a person to a child of a person's child.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has grandchild</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandChild">cwrc:hasGrandChild</a>
    /// </summary>
    let hasGrandChild = _prefixId.prefix "hasGrandChild"
    /// <summary>
    ///   <para>rdfs:label : has granddaughterrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : Relates a person to a female-identified child of a person's child.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandDaughter">cwrc:hasGrandDaughter</a>
    /// </summary>
    let hasGrandDaughter = _prefixId.prefix "hasGrandDaughter"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the father of their mother or father.skos:definition : </para>
    ///   <para>rdfs:label : has grandfatherrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandFather">cwrc:hasGrandFather</a>
    /// </summary>
    let hasGrandFather = _prefixId.prefix "hasGrandFather"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the mother of their mother or father.skos:definition : </para>
    ///   <para>rdfs:label : has grandmotherrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandMother">cwrc:hasGrandMother</a>
    /// </summary>
    let hasGrandMother = _prefixId.prefix "hasGrandMother"
    /// <summary>
    ///   <para>rdfs:label : has grandparentrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : Relates a person to the parent of their mother or father.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandParent">cwrc:hasGrandParent</a>
    /// </summary>
    let hasGrandParent = _prefixId.prefix "hasGrandParent"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a male-identified child of a person's child.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has grandson</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGrandSon">cwrc:hasGrandSon</a>
    /// </summary>
    let hasGrandSon = _prefixId.prefix "hasGrandSon"
    /// <summary>
    ///   <para>skos:definition : Relates a person (usually a minor) to another, usually an adult who is charged with their care. This term stretches beyond the legal definition of "guardian" to include a broader social relation between dependant and dependee (e.g.: &lt;i&gt;in loco parentis&lt;/i&gt;)</para>
    ///   <para>rdfs:label : has guardianrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasGuardian">cwrc:hasGuardian</a>
    /// </summary>
    let hasGuardian = _prefixId.prefix "hasGuardian"
    /// <summary>
    ///   <para>rdfs:label : has half-brotherrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : Relates a male-identified person to the someone with whom they have one parent in common.</para>
    ///   <para>skos:note : Comment: This term is a CWRC-specific addition not in the original Orlando tag set.^^xsd:string</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasHalfBrother">cwrc:hasHalfBrother</a>
    /// </summary>
    let hasHalfBrother = _prefixId.prefix "hasHalfBrother"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Relates a female-identified person to the someone with whom they have one parent in common.</para>
    ///   <para>rdfs:label : rdfs:label : has half-sister</para>
    ///   <para>skos:note : Comment: This term is a CWRC-specific addition not in the original Orlando tag set.^^xsd:string</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasHalfSister">cwrc:hasHalfSister</a>
    /// </summary>
    let hasHalfSister = _prefixId.prefix "hasHalfSister"
    /// <summary>
    ///   <para>rdfs:label : has husbandrdfs:label : </para>
    ///   <para>skos:definition : Relates a person to a male-identified partner in a marital relationship.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasHusband">cwrc:hasHusband</a>
    /// </summary>
    let hasHusband = _prefixId.prefix "hasHusband"
    /// <summary>
    ///   <para>skos:definition : Indicates that the subject entity is dependent upon the identifications made in the object entity. For instance, this predicate can be used to link web annotations with bodies containing RDF triples to annotations that identify entities used in those triples.skos:definition : </para>
    ///   <para>rdfs:label : has ID dependency onrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasIDependencyOn">cwrc:hasIDependencyOn</a>
    /// </summary>
    let hasIDependencyOn = _prefixId.prefix "hasIDependencyOn"
    /// <summary>
    ///   <para>rdfs:label : has immigrantrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasImmigrant">cwrc:hasImmigrant</a>
    /// </summary>
    let hasImmigrant = _prefixId.prefix "hasImmigrant"
    /// <summary>
    ///   <para>rdfs:label : has inhabitantrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasInhabitant">cwrc:hasInhabitant</a>
    /// </summary>
    let hasInhabitant = _prefixId.prefix "hasInhabitant"
    /// <summary>
    ///   <para>skos:definition : Décrit la relation du sujet avec un instructeur pédagogique ou un·e mentor·e, formel·le ou informel·le.skos:definition : Describes the subject's relationship with an educational instructor or mentor, formal or informal.</para>
    ///   <para>rdfs:label : has instructorrdfs:label : a un instructeur·ice</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasInstructor">cwrc:hasInstructor</a>
    /// </summary>
    let hasInstructor = _prefixId.prefix "hasInstructor"

    /// <summary>
    ///   <para>skos:definition : Indicates personal knowledge of someone, covering a broad spectrum of social relations ranging from friendship to enmities and casual associations: it can include a writer having coffee with Samuel Johnson on one notable day, without needing a historical record of whether they were necessarily friends, through to substantial longlasting relationships. See also &lt;a href="#hasIntimateRelationshipWith" title="#hasIntimateRelationshipWith"&gt;has intimate relationship with&lt;/a&gt;, &lt;a href="#hasEroticRelationshipWith" title="#hasEroticRelationshipWith"&gt;has erotic relationship with&lt;/a&gt;, &lt;a href="#hasPossiblyEroticRelationshipWith" title="#hasPossiblyEroticRelationshipWith"&gt;has possibly erotic relationship with&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : has interpersonal relationship withrdfs:label : a relation interpersonnelle avec</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasInterpersonalRelationshipWith">cwrc:hasInterpersonalRelationshipWith</a>
    /// </summary>
    let hasInterpersonalRelationshipWith = _prefixId.prefix "hasInterpersonalRelationshipWith"

    /// <summary>
    ///   <para>skos:definition : Indicates a relationship that involves any type of intimacy ranging from emotional through psychological or material to sexual. Counters the traditional assumption that the only intimate relations happen within the context of marriage or heterosexual relations between sexual partners, challenging the historical and ideological silence placed upon same-sex relationships. For instance, it includes lifelong female friendships, defining psychological connections, or erotically-charged same sex or opposite sex relationships. It may or may not be erotic, and may apply to both brief sexual affairs and lifelong non-sexual relationships. Biographical information concerning these relationships is often scant; therefore this predicate recognizes these relations as significant while not assuming that they were sexual. See &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;has interpersonal relationship with&lt;/a&gt;, &lt;a href="#hasEroticRelationshipWith" title="#hasEroticRelationshipWith"&gt;has erotic relationship with&lt;/a&gt;, &lt;a href="#hasPossiblyEroticRelationshipWith" title="#hasPossiblyEroticRelationshipWith"&gt;has possibly erotic relationship with&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has intimate relationship with</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasIntimateRelationshipWith">cwrc:hasIntimateRelationshipWith</a>
    /// </summary>
    let hasIntimateRelationshipWith = _prefixId.prefix "hasIntimateRelationshipWith"
    /// <summary>
    ///   <para>skos:definition : Knowledge of the language for speaking, writing, or reading, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. As with other cultural forms, an individual may have more than one property or descriptor of this type.skos:definition : Capacité d'écrire ou de lire une langue.</para>
    ///   <para>rdfs:label : maîtrise une languerdfs:label : language known</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbility">cwrc:hasLinguisticAbility</a>
    /// </summary>
    let hasLinguisticAbility = _prefixId.prefix "hasLinguisticAbility"
    /// <summary>
    ///   <para>rdfs:label : maîtrise une langue (déclaré)rdfs:label : language known (reported)</para>
    ///   <para>skos:definition : Le sujet déclare maîtriser une langue à l'oral ou à l'écrit. Pour plus d'information sur cette propriété, voir &lt;a href="#LinguisticAbility" title="#LinguisticAbility"&gt;aptitude linguistique (écrit ou parlé)&lt;/a&gt;.skos:definition : Reported knowledge of the language for speaking, writing, or reading, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. For further information about this property, see &lt;a href="#LinguisticAbility" title="#LinguisticAbility"&gt;linguistic ability (spoken and/or writen)&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilityReported">cwrc:hasLinguisticAbilityReported</a>
    /// </summary>
    let hasLinguisticAbilityReported = _prefixId.prefix "hasLinguisticAbilityReported"

    let hasLinguisticAbilitySelfDeclared = _prefixId.prefix "hasLinguisticAbilitySelfDeclared"

    /// <summary>
    ///   <para>rdfs:label : maîtrise une langue (autodéclaré)rdfs:label : language known (self-reported)</para>
    ///   <para>skos:definition : Le sujet déclare maîtriser une langue à l'oral ou à l'écrit. Pour plus d'information sur cette propriété, voir &lt;a href="#LinguisticAbility" title="#LinguisticAbility"&gt;aptitude linguistique (écrit ou parlé)&lt;/a&gt;.skos:definition : Self-reported knowledge of the language for speaking, writing, or reading, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. For further information about this property, see &lt;a href="#LinguisticAbility" title="#LinguisticAbility"&gt;linguistic ability (spoken and/or writen)&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasLinguisticAbilitySelfReported">cwrc:hasLinguisticAbilitySelfReported</a>
    /// </summary>
    let hasLinguisticAbilitySelfReported = _prefixId.prefix "hasLinguisticAbilitySelfReported"

    /// <summary>
    ///   <para>skos:definition : The location of a thing. For example where an event took place or a organization is locatedskos:definition : </para>
    ///   <para>rdfs:label : has locationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasLocation">cwrc:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Relates a person to their mother, the female-identified parent, consanguineal or otherwise.</para>
    ///   <para>rdfs:label : has motherrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasMother">cwrc:hasMother</a>
    /// </summary>
    let hasMother = _prefixId.prefix "hasMother"
    /// <summary>
    ///   <para>skos:definition : Indicates a person's name.</para>
    ///   <para>rdfs:label : has namerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasName">cwrc:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>skos:definition : Indicates a component of a name. Order of name parts is indicated by &lt;a href="#hasSortOrder" title="#hasSortOrder"&gt;has sort order&lt;/a&gt;skos:definition : </para>
    ///   <para>rdfs:label : has name partrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNamePart">cwrc:hasNamePart</a>
    /// </summary>
    let hasNamePart = _prefixId.prefix "hasNamePart"
    /// <summary>
    ///   <para>rdfs:label : has national heritagerdfs:label : de héritage national</para>
    ///   <para>skos:definition : skos:definition : Describes a person's &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;national heritage&lt;/a&gt;, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritage">cwrc:hasNationalHeritage</a>
    /// </summary>
    let hasNationalHeritage = _prefixId.prefix "hasNationalHeritage"
    /// <summary>
    ///   <para>rdfs:label : de héritage national (déclarée)rdfs:label : has national heritage (reported)</para>
    ///   <para>skos:definition : Describes a person's reported &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;national heritage&lt;/a&gt;, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageReported">cwrc:hasNationalHeritageReported</a>
    /// </summary>
    let hasNationalHeritageReported = _prefixId.prefix "hasNationalHeritageReported"

    /// <summary>
    ///   <para>rdfs:label : de héritage national (autodéclarée)rdfs:label : has national heritage (self-reported)</para>
    ///   <para>skos:definition : Describes a person's self-reported &lt;a href="#NationalHeritage" title="#NationalHeritage"&gt;national heritage&lt;/a&gt;, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalHeritageSelfReported">cwrc:hasNationalHeritageSelfReported</a>
    /// </summary>
    let hasNationalHeritageSelfReported = _prefixId.prefix "hasNationalHeritageSelfReported"

    /// <summary>
    ///   <para>skos:definition : Describes a person's &lt;a href="#NationalIdentity" title="#NationalIdentity"&gt;national identity&lt;/a&gt; identity, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type.skos:definition : Décrit la &lt;a href="#NationalIdentity" title="#NationalIdentity"&gt;identité nationale&lt;/a&gt; d'une personne. De même que pour les autres formes culturelles, une même personne peut cumuler plus d'une propriété ou description de ce type.</para>
    ///   <para>rdfs:label : de nationalitérdfs:label : has national identity</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationality">cwrc:hasNationality</a>
    /// </summary>
    let hasNationality = _prefixId.prefix "hasNationality"
    /// <summary>
    ///   <para>skos:definition : This property indicates a person's reported national identity, with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. It is neither the same as citizenship nor commensurate with the geographical region or territory in which a person resides. For more information on this property see &lt;a href="#NationalIdentity" title="#NationalIdentity"&gt;national identity&lt;/a&gt;.skos:definition : Décrit la/les nationalité(s) proclamée(s) d'une personne, différant de la citoyenneté et n'étant pas proportionnelle à la zone géographique ou au territoire sur lequel elle réside.</para>
    ///   <para>rdfs:label : has national identity (reported)rdfs:label : de nationalité (déclarée)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalityReported">cwrc:hasNationalityReported</a>
    /// </summary>
    let hasNationalityReported = _prefixId.prefix "hasNationalityReported"
    let hasNationalitySelfDeclared = _prefixId.prefix "hasNationalitySelfDeclared"
    /// <summary>
    ///   <para>skos:definition : Décrit la/les nationalité(s) autoproclamée(s) d'une personne, différant de la citoyenneté et n'étant pas proportionnelle à la zone géographique ou au territoire sur lequel elle réside.skos:definition : This property indicates a person's self-reported national identity, with with accompanying context, where present, provided by &lt;a href="#NationalityContext" title="#NationalityContext"&gt;nationality context&lt;/a&gt; annotations. It is neither the same as citizenship nor commensurate with the geographical region or territory in which a person resides. For more information on this property see &lt;a href="#NationalIdentity" title="#NationalIdentity"&gt;national identity&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has national identity (self-reported)rdfs:label : de nationalité (autodéclarée)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNationalitySelfReported">cwrc:hasNationalitySelfReported</a>
    /// </summary>
    let hasNationalitySelfReported = _prefixId.prefix "hasNationalitySelfReported"
    /// <summary>
    ///   <para>skos:definition : Knowledge of the language, acquired during a person’s upbringing, for speaking, writing or reading, which may be self-reported or reported by another, and with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. As with other cultural forms, an individual may have more than one property or descriptor of this type.skos:definition : Capacité d'écrire ou de lire une langue acquise dès l'enfance. Comme pour d'autres formes culturelles, un individu peut avoir plus d'une propriété ou descripteur de ce type. </para>
    ///   <para>rdfs:label : natively known languagerdfs:label : langue native</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbility">cwrc:hasNativeLinguisticAbility</a>
    /// </summary>
    let hasNativeLinguisticAbility = _prefixId.prefix "hasNativeLinguisticAbility"

    /// <summary>
    ///   <para>rdfs:label : langue native (déclarée)rdfs:label : natively known language (reported)</para>
    ///   <para>skos:definition : Reported knowledge of the language, acquired during a person’s upbringing, for speaking, writing, or reading,  with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;.skos:definition :  Le sujet déclare lire et écrire une langue maîtrisée depuis l'enfance. </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilityReported">cwrc:hasNativeLinguisticAbilityReported</a>
    /// </summary>
    let hasNativeLinguisticAbilityReported = _prefixId.prefix "hasNativeLinguisticAbilityReported"

    let hasNativeLinguisticAbilitySelfDeclared = _prefixId.prefix "hasNativeLinguisticAbilitySelfDeclared"

    /// <summary>
    ///   <para>rdfs:label : natively known language (self-reported)rdfs:label : langue native (autodéclarée)</para>
    ///   <para>skos:definition : Self-reported knowledge of the language, acquired during a person’s upbringing, for speaking, writing, or reading,  with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;.skos:definition : Connaissance parlée, écrite ou lue d'une langue acquise durant l'éducation, qui peut être autodéclarée ou assignée par une autre personne, accompagné par le contexte fourni par le contexte de &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;forme culturelle en contexte&lt;/a&gt; lorsqu'il est disponible. Comme pour d'autres formes culturelles, un individu peut avoir plus d'une propriété ou descripteur de ce type.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNativeLinguisticAbilitySelfReported">cwrc:hasNativeLinguisticAbilitySelfReported</a>
    /// </summary>
    let hasNativeLinguisticAbilitySelfReported = _prefixId.prefix "hasNativeLinguisticAbilitySelfReported"

    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has nephew</para>
    ///   <para>skos:definition : Relates a person to the son of their sibling.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNephew">cwrc:hasNephew</a>
    /// </summary>
    let hasNephew = _prefixId.prefix "hasNephew"
    /// <summary>
    ///   <para>skos:definition : Relates a person to the daughter of their sibling.skos:definition : </para>
    ///   <para>rdfs:label : has niecerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNiece">cwrc:hasNiece</a>
    /// </summary>
    let hasNiece = _prefixId.prefix "hasNiece"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has non-erotic relationship with</para>
    ///   <para>skos:definition : Describes an intimate relationship with the subject that is neither erotic nor sexual in nature. See &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;has interpersonal relationship with&lt;/a&gt;, &lt;a href="#hasEroticRelationshipWith" title="#hasEroticRelationshipWith"&gt;has erotic relationship with&lt;/a&gt;, &lt;a href="#hasIntimateRelationshipWith" title="#hasIntimateRelationshipWith"&gt;has intimate relationship with&lt;/a&gt;, &lt;a href="#hasPossiblyEroticRelationshipWith" title="#hasPossiblyEroticRelationshipWith"&gt;has possibly erotic relationship with&lt;/a&gt;.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasNonEroticRelationshipWith">cwrc:hasNonEroticRelationshipWith</a>
    /// </summary>
    let hasNonEroticRelationshipWith = _prefixId.prefix "hasNonEroticRelationshipWith"
    /// <summary>
    ///   <para>skos:definition : Indicates a regular position or activity significant to a person's life, including paid, unpaid, and voluntary work.skos:definition : </para>
    ///   <para>rdfs:label : has occupationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasOccupation">cwrc:hasOccupation</a>
    /// </summary>
    let hasOccupation = _prefixId.prefix "hasOccupation"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Describes or provides information regarding a person's incomes related to an occupation.</para>
    ///   <para>rdfs:label : has occupation incomerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasOccupationIncome">cwrc:hasOccupationIncome</a>
    /// </summary>
    let hasOccupationIncome = _prefixId.prefix "hasOccupationIncome"
    /// <summary>
    ///   <para>skos:definition : Indicates that the organization in question belongs in some sense to the specified conceptual entity. For instance, a particular religion may have one or more organizational groups associated with it, a political campaign may have multiple political groups associated with it simultaneously or sequentially, or an artistic movement may have various contributing groups.skos:definition : </para>
    ///   <para>rdfs:label : has organizationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasOrganization">cwrc:hasOrganization</a>
    /// </summary>
    let hasOrganization = _prefixId.prefix "hasOrganization"
    /// <summary>
    ///   <para>skos:definition : Indicates a position or activity for which a person was paid.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has paid occupation</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPaidOccupation">cwrc:hasPaidOccupation</a>
    /// </summary>
    let hasPaidOccupation = _prefixId.prefix "hasPaidOccupation"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has parent</para>
    ///   <para>skos:definition : Relates a person to their father, mother, or, in certain cases, their guardian.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasParent">cwrc:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>skos:definition : Associates an event with a person.skos:definition : </para>
    ///   <para>rdfs:label : has participantrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasParticipant">cwrc:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has partner</para>
    ///   <para>skos:definition : Relates two people through a romantic, emotional, or spousal relationship. Distinct from a business or corporate partnership.skos:definition : Ce terme représente uniquement les relations affectives, amoureuses ou familiales et non des relations d'affaires.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPartner">cwrc:hasPartner</a>
    /// </summary>
    let hasPartner = _prefixId.prefix "hasPartner"
    let hasPeformance = _prefixId.prefix "hasPeformance"
    /// <summary>
    ///   <para>skos:definition : Associe un persona à une ou plusieurs personne(s) physique(s).skos:definition : Associates a &lt;a href="#Persona" title="#Persona"&gt;persona&lt;/a&gt; with one more &lt;a href="#NaturalPerson" title="#NaturalPerson"&gt;natural person&lt;/a&gt;(s). </para>
    ///   <para>rdfs:label : has personardfs:label : a persona</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPersona">cwrc:hasPersona</a>
    /// </summary>
    let hasPersona = _prefixId.prefix "hasPersona"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Describes a person's political affiliation, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#PoliticalContext" title="#PoliticalContext"&gt;politics context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type, and it may be linked to &lt;a href="#PoliticalAffiliation" title="#PoliticalAffiliation"&gt;political affiliations&lt;/a&gt; or directly to an organization which may or may not be primarily political. For further information about this property, see &lt;a href="#PoliticalAffiliation" title="#PoliticalAffiliation"&gt;political affiliation&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has political affiliationrdfs:label : a une appartenance politique</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliation">cwrc:hasPoliticalAffiliation</a>
    /// </summary>
    let hasPoliticalAffiliation = _prefixId.prefix "hasPoliticalAffiliation"

    /// <summary>
    ///   <para>rdfs:label : has political affiliation (reported)rdfs:label : </para>
    ///   <para>skos:definition : Describes a person's reported political affiliation. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#PoliticalAffiliation" title="#PoliticalAffiliation"&gt;political affiliation&lt;/a&gt;.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationReported">cwrc:hasPoliticalAffiliationReported</a>
    /// </summary>
    let hasPoliticalAffiliationReported = _prefixId.prefix "hasPoliticalAffiliationReported"

    /// <summary>
    ///   <para>skos:definition : skos:definition : Describes a person's self-reported political affiliation. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#PoliticalAffiliation" title="#PoliticalAffiliation"&gt;political affiliation&lt;/a&gt;.</para>
    ///   <para>rdfs:label : a une appartenance politique (autodéclarée)rdfs:label : has political affiliation (self-reported)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalAffiliationSelfReported">cwrc:hasPoliticalAffiliationSelfReported</a>
    /// </summary>
    let hasPoliticalAffiliationSelfReported = _prefixId.prefix "hasPoliticalAffiliationSelfReported"

    /// <summary>
    ///   <para>rdfs:label : has political involvement fromrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementFrom">cwrc:hasPoliticalInvolvementFrom</a>
    /// </summary>
    let hasPoliticalInvolvementFrom = _prefixId.prefix "hasPoliticalInvolvementFrom"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Indicates some level of political involvement.</para>
    ///   <para>rdfs:label : rdfs:label : has political involvement in</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalInvolvementIn">cwrc:hasPoliticalInvolvementIn</a>
    /// </summary>
    let hasPoliticalInvolvementIn = _prefixId.prefix "hasPoliticalInvolvementIn"
    /// <summary>
    ///   <para>rdfs:label : has political membership fromrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipFrom">cwrc:hasPoliticalMembershipFrom</a>
    /// </summary>
    let hasPoliticalMembershipFrom = _prefixId.prefix "hasPoliticalMembershipFrom"
    /// <summary>
    ///   <para>rdfs:label : has political membership inrdfs:label : </para>
    ///   <para>skos:definition : Indicates some degree of sustained engagement with an organization such as a political group or literary movement. Does not necessarily denote formal membership, but rather points to clear evidence of a link with an organization without indication of more active participation: a person may have been a member of the &lt;a href="#sanitaryMovement" title="#sanitaryMovement"&gt;sanitary movement&lt;/a&gt; or participated in a reading associated with a particular literary movement.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPoliticalMembershipIn">cwrc:hasPoliticalMembershipIn</a>
    /// </summary>
    let hasPoliticalMembershipIn = _prefixId.prefix "hasPoliticalMembershipIn"

    /// <summary>
    ///   <para>skos:definition : skos:definition : Describes an intimate relationship that may or may not be erotic in nature. This predicate seeks to redress the historical and ideological silence placed upon same sex relationships; it recognizes that biographical information concerning these relationships often is impossible to uncover. &lt;a href="#hasPossiblyEroticRelationshipWith" title="#hasPossiblyEroticRelationshipWith"&gt;has possibly erotic relationship with&lt;/a&gt; registers the possibility of a sexual relationship, when, in the absence of biographical proof, it is impossible to claim such as fact. See &lt;a href="#hasInterpersonalRelationshipWith" title="#hasInterpersonalRelationshipWith"&gt;has interpersonal relationship with&lt;/a&gt;, &lt;a href="#hasEroticRelationshipWith" title="#hasEroticRelationshipWith"&gt;has erotic relationship with&lt;/a&gt;, &lt;a href="#hasIntimateRelationshipWith" title="#hasIntimateRelationshipWith"&gt;has intimate relationship with&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has possibly erotic relationship withrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasPossiblyEroticRelationshipWith">cwrc:hasPossiblyEroticRelationshipWith</a>
    /// </summary>
    let hasPossiblyEroticRelationshipWith = _prefixId.prefix "hasPossiblyEroticRelationshipWith"

    /// <summary>
    ///   <para>rdfs:label : has race or colour identityrdfs:label : est de race our couleur</para>
    ///   <para>skos:definition : This describes a person's identity with respect to race or colour, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. As with other cultural forms, an individual may have more than one property or descriptor of this type. For more information on this property see &lt;a href="#RaceColour" title="#RaceColour"&gt;race or colour&lt;/a&gt;.skos:definition : Décrit l'identité raciale d'une personne. Pour plus d'information sur cette propriété, voir &lt;a href="#RaceColour" title="#RaceColour"&gt;race ou couleur&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColour">cwrc:hasRaceColour</a>
    /// </summary>
    let hasRaceColour = _prefixId.prefix "hasRaceColour"
    /// <summary>
    ///   <para>skos:definition : Indicates a person's reported identity with respect to race or colour, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. For further information about this property, see &lt;a href="#RaceColour" title="#RaceColour"&gt;race or colour&lt;/a&gt;.skos:definition : Décrit l'appartenance raciale ou la couleur déclarées d'une personne. Pour plus d'informations à propre de cette propriété, voir &lt;a href="#RaceColour" title="#RaceColour"&gt;race ou couleur&lt;/a&gt;. </para>
    ///   <para>rdfs:label : race ou couleur (déclarée)rdfs:label : has race or colour identity (reported)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourReported">cwrc:hasRaceColourReported</a>
    /// </summary>
    let hasRaceColourReported = _prefixId.prefix "hasRaceColourReported"
    let hasRaceColourSelfDeclared = _prefixId.prefix "hasRaceColourSelfDeclared"
    /// <summary>
    ///   <para>skos:definition : Indicates a person's self-reported identity with respect to race or colour, with accompanying context, where present, provided by &lt;a href="#RaceEthnicityContext" title="#RaceEthnicityContext"&gt;race or ethnicity context&lt;/a&gt; annotations. For further information about this property, see &lt;a href="#RaceColour" title="#RaceColour"&gt;race or colour&lt;/a&gt;.skos:definition : Décrit l'appartenance raciale ou la couleur autodéclarées d'une personne. Pour plus d'informations à propre de cette propriété, voir &lt;a href="#RaceColour" title="#RaceColour"&gt;race ou couleur&lt;/a&gt;. </para>
    ///   <para>rdfs:label : has race or colour identity (self-reported)rdfs:label : race ou couleur (autodéclarée)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasRaceColourSelfReported">cwrc:hasRaceColourSelfReported</a>
    /// </summary>
    let hasRaceColourSelfReported = _prefixId.prefix "hasRaceColourSelfReported"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has relative</para>
    ///   <para>skos:definition : Has a familial relationship to a person. hasRelative and its subproperties indicate social aspects of familial relations as opposed to biological ones; for example, &lt;a href="#hasMother" title="#hasMother"&gt;has mother&lt;/a&gt; is not necessarily a consanguineal relationship -- although both can be present. Family relationships are subproperties of social relationships. For more information, see &lt;a href="http://dbpedia.org/page/Family" title="http://dbpedia.org/page/Family"&gt;About: Family&lt;/a&gt;. This property indicates either a general familial relationship or one that is complicated or not easily categorisable in traditional kinship terms.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasRelative">cwrc:hasRelative</a>
    /// </summary>
    let hasRelative = _prefixId.prefix "hasRelative"
    /// <summary>
    ///   <para>skos:definition : Décrit la religion d'une personne. De même que pour les autres formes culturelles, une même personne peut cumuler plus d'une propriété ou description de ce type. Pour plus d'informations sur cette propriété, voir &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;.skos:definition : Indicates a person's religion or belief system, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt; annotations. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;.</para>
    ///   <para>rdfs:label : est de confessionrdfs:label : has religious affiliation</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligion">cwrc:hasReligion</a>
    /// </summary>
    let hasReligion = _prefixId.prefix "hasReligion"
    /// <summary>
    ///   <para>skos:definition : Décrit indique la/les religion(s) ou le(s) système(s) de croyance proclamé(s) par une personne. Pour plus d'informations sur cette propriété, voir &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;.skos:definition : Indicates a person's reported religion or belief system, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt; annotations. For further information about this property, see &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has religious affiliation (reported)rdfs:label : religion (déclarée)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionReported">cwrc:hasReligionReported</a>
    /// </summary>
    let hasReligionReported = _prefixId.prefix "hasReligionReported"
    let hasReligionSelfDefined = _prefixId.prefix "hasReligionSelfDefined"
    /// <summary>
    ///   <para>skos:definition : Décrit indique la/les religion(s) ou le(s) système(s) de croyance autoproclamé(s) par une personne. Pour plus d'informations sur cette propriété, voir &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;.skos:definition : Indicates a person's self-reported religion or belief system, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt; annotations. For further information about this property, see &lt;a href="#Religion" title="#Religion"&gt;religion&lt;/a&gt;.</para>
    ///   <para>rdfs:label : has religious affiliation (self-reported)rdfs:label : religion (autodéclarée)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasReligionSelfReported">cwrc:hasReligionSelfReported</a>
    /// </summary>
    let hasReligionSelfReported = _prefixId.prefix "hasReligionSelfReported"
    /// <summary>
    ///   <para>rdfs:label : has relocateerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasRelocatee">cwrc:hasRelocatee</a>
    /// </summary>
    let hasRelocatee = _prefixId.prefix "hasRelocatee"
    /// <summary>
    ///   <para>skos:definition : Describes an aspect of a person's reproductive history.  May relate to childlessness, birth control, adoption, abortion, difficulties with childbearing, loss of a child, whether biologically related, adopted, or otherwise considered kin, difficulties with child-bearing. See also the related property &lt;a href="#hasChildren" title="#hasChildren"&gt;has children&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : has reproductive historyrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasReproductiveHistory">cwrc:hasReproductiveHistory</a>
    /// </summary>
    let hasReproductiveHistory = _prefixId.prefix "hasReproductiveHistory"
    /// <summary>
    ///   <para>skos:definition : Associates an event element to a role.skos:definition : </para>
    ///   <para>rdfs:label : has rolerdfs:label : a un rôle</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasRole">cwrc:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : a une orientation sexuellerdfs:label : has sexual identity</para>
    ///   <para>skos:definition : Décrit la sexualité d'une personne. Comme que pour les autres formes culturelles, une même personne peut cumuler plus d'une propriété ou description de ce type. Pour plus d'informations sur cette propriété, voir &lt;a href="#Sexuality" title="#Sexuality"&gt;sexualité&lt;/a&gt;.skos:definition : Describes a person's sexual identity, which may be self-reported or reported by another,  with accompanying context, where present, provided by &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexuality context&lt;/a&gt;. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexuality">cwrc:hasSexuality</a>
    /// </summary>
    let hasSexuality = _prefixId.prefix "hasSexuality"
    /// <summary>
    ///   <para>skos:definition : Décrit la sexualité déclarée d'une personne. Pour plus d'information, voir &lt;a href="#Sexuality" title="#Sexuality"&gt;sexualité&lt;/a&gt; et &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexualité en contexte&lt;/a&gt;.skos:definition : This describes a person's reported sexual identity,  with accompanying context, where present, provided by &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexuality context&lt;/a&gt;. For more information, see &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt; and &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexuality context&lt;/a&gt;.</para>
    ///   <para>rdfs:label : a une orientation sexuelle (déclarée)rdfs:label : has sexual identity (reported)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualityReported">cwrc:hasSexualityReported</a>
    /// </summary>
    let hasSexualityReported = _prefixId.prefix "hasSexualityReported"
    let hasSexualitySelfDeclared = _prefixId.prefix "hasSexualitySelfDeclared"
    /// <summary>
    ///   <para>rdfs:label : a une orientation sexuelle (autodéclarée)rdfs:label : has sexual identity (self-reported)</para>
    ///   <para>skos:definition : Describes a person's self-reported sexual identity,  with accompanying context, where present, provided by &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexuality context&lt;/a&gt;. For more information, see &lt;a href="#Sexuality" title="#Sexuality"&gt;sexuality&lt;/a&gt; and &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexuality context&lt;/a&gt;.skos:definition : Décrit la sexualité autodéclarée d'une personne. Pour plus d'information, voir &lt;a href="#Sexuality" title="#Sexuality"&gt;sexualité&lt;/a&gt; et &lt;a href="#SexualityContext" title="#SexualityContext"&gt;sexualité en contexte&lt;/a&gt;.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSexualitySelfReported">cwrc:hasSexualitySelfReported</a>
    /// </summary>
    let hasSexualitySelfReported = _prefixId.prefix "hasSexualitySelfReported"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Describes a relationship in which two or more individuals share the same parentage.</para>
    ///   <para>rdfs:label : rdfs:label : has sibling</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSibling">cwrc:hasSibling</a>
    /// </summary>
    let hasSibling = _prefixId.prefix "hasSibling"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a female-identified sibling. Although the term typically refers to consanguineal relationships, it is often used to describe relationships beyond "blood ties".
    ///     skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has sister</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSister">cwrc:hasSister</a>
    /// </summary>
    let hasSister = _prefixId.prefix "hasSister"
    /// <summary>
    ///   <para>skos:definition : Describes a person's class identity, which may be self-reported or reported by another, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. As with other &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural forms&lt;/a&gt;, an individual may have more than one property or descriptor of this type. For further information about this property, see &lt;a href="#SocialClass" title="#SocialClass"&gt;social class&lt;/a&gt;.skos:definition : Décrit la classe sociale d'une personne. Comme pour les autres formes culturelles, une même personne peut cumuler plus d'une propriété ou description de ce type. Pour plus d'informations sur cette propriété, voir &lt;a href="#SocialClass" title="#SocialClass"&gt;classe sociale&lt;/a&gt;.</para>
    ///   <para>rdfs:label : a une classe socialerdfs:label : has class identity</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClass">cwrc:hasSocialClass</a>
    /// </summary>
    let hasSocialClass = _prefixId.prefix "hasSocialClass"
    /// <summary>
    ///   <para>rdfs:label : a classe sociale déclaréerdfs:label : has class identity (reported)</para>
    ///   <para>skos:definition : Describes a person's reported class identity, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. For further information about this property, see &lt;a href="#SocialClass" title="#SocialClass"&gt;social class&lt;/a&gt;.skos:definition : Décrit la classe social déclarée d'une personne. Pour plus d'informations sur cette propriété, voir &lt;a href="#SocialClass" title="#SocialClass"&gt;classe sociale&lt;/a&gt;. </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassReported">cwrc:hasSocialClassReported</a>
    /// </summary>
    let hasSocialClassReported = _prefixId.prefix "hasSocialClassReported"
    let hasSocialClassSelfDefined = _prefixId.prefix "hasSocialClassSelfDefined"
    /// <summary>
    ///   <para>skos:definition : Décrit la classe social autodéclarée d'une personne. Pour plus d'informations sur cette propriété, voir &lt;a href="#SocialClass" title="#SocialClass"&gt;classe sociale&lt;/a&gt;. skos:definition : Describes a person's self-reported class identity, with accompanying context, where present, provided by &lt;a href="#CulturalFormContext" title="#CulturalFormContext"&gt;cultural form context&lt;/a&gt;. For further information about this property, see &lt;a href="#SocialClass" title="#SocialClass"&gt;social class&lt;/a&gt;.</para>
    ///   <para>rdfs:label : a classe sociale autodéclaréerdfs:label : has class identity (self-reported)</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialClassSelfReported">cwrc:hasSocialClassSelfReported</a>
    /// </summary>
    let hasSocialClassSelfReported = _prefixId.prefix "hasSocialClassSelfReported"
    /// <summary>
    ///   <para>skos:definition : Any relationship between persons. See &lt;a href="https://en.wikipedia.org/wiki/Social_relation" title="https://en.wikipedia.org/wiki/Social_relation"&gt;Social relation - Wikipedia&lt;/a&gt; skos:definition : </para>
    ///   <para>rdfs:label : has social relationship withrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSocialRelationshipWith">cwrc:hasSocialRelationshipWith</a>
    /// </summary>
    let hasSocialRelationshipWith = _prefixId.prefix "hasSocialRelationshipWith"
    /// <summary>
    ///   <para>rdfs:label : has sonrdfs:label : </para>
    ///   <para>skos:definition : Relates a person to a male-identified child, consanguineal or otherwise.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSon">cwrc:hasSon</a>
    /// </summary>
    let hasSon = _prefixId.prefix "hasSon"
    /// <summary>
    ///   <para>skos:definition : Indicates the order in which the parts of a name occur.skos:definition : </para>
    ///   <para>rdfs:label : has sort orderrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasSortOrder">cwrc:hasSortOrder</a>
    /// </summary>
    let hasSortOrder = _prefixId.prefix "hasSortOrder"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a male-identified stepsibling, that is, a child of the person's stepparent.skos:definition : </para>
    ///   <para>rdfs:label : has stepbrotherrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepBrother">cwrc:hasStepBrother</a>
    /// </summary>
    let hasStepBrother = _prefixId.prefix "hasStepBrother"
    /// <summary>
    ///   <para>rdfs:label : has stepchildrdfs:label : </para>
    ///   <para>skos:definition : Relates a person to the child of that person's spouse, in contrast to what is commonly referred to as the "biological parent" of said child.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepChild">cwrc:hasStepChild</a>
    /// </summary>
    let hasStepChild = _prefixId.prefix "hasStepChild"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Relates a person to a female-identified child of that person's spouse, in contrast to what is commonly referred to as the "biological parent" of said child.</para>
    ///   <para>rdfs:label : has stepdaughterrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepDaughter">cwrc:hasStepDaughter</a>
    /// </summary>
    let hasStepDaughter = _prefixId.prefix "hasStepDaughter"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Relates a person to their stepfather, that is, a parent married to that person's so-called "biological parent", in contrast to a consanguineal relationship.</para>
    ///   <para>rdfs:label : rdfs:label : has stepfather</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepFather">cwrc:hasStepFather</a>
    /// </summary>
    let hasStepFather = _prefixId.prefix "hasStepFather"
    /// <summary>
    ///   <para>rdfs:label : has stepmotherrdfs:label : </para>
    ///   <para>skos:definition : Relates a person to their stepmother, that is, a parent married to that person's so-called "biological parent", in contrast to a consanguineal relationship.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepMother">cwrc:hasStepMother</a>
    /// </summary>
    let hasStepMother = _prefixId.prefix "hasStepMother"
    /// <summary>
    ///   <para>skos:definition : Relates a person to their stepparent, that is, a parent married to that person's so-called "biological parent", in contrast to a consanguineal relationship.skos:definition : </para>
    ///   <para>rdfs:label : rdfs:label : has stepparent</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepParent">cwrc:hasStepParent</a>
    /// </summary>
    let hasStepParent = _prefixId.prefix "hasStepParent"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a female-identified stepsibling, that is, a child of the person's stepparent.skos:definition : </para>
    ///   <para>rdfs:label : has stepsisterrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepSister">cwrc:hasStepSister</a>
    /// </summary>
    let hasStepSister = _prefixId.prefix "hasStepSister"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Relates a person to a male-identified child of that person's spouse, in contrast to what is commonly referred to as the "biological parent" of said child.</para>
    ///   <para>rdfs:label : has stepsonrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStepSon">cwrc:hasStepSon</a>
    /// </summary>
    let hasStepSon = _prefixId.prefix "hasStepSon"
    /// <summary>
    ///   <para>skos:definition : Indique que l'étudiant·e a été éduqué·e par l'entité en question (instructeur·rice, établissement éducatif,ou type d'éducation particulière).skos:definition : Indicates that the student was educated by the entity in question,—an instructor, an educational institution, or a particular type of schooling.</para>
    ///   <para>rdfs:label : has studentrdfs:label : a un·e étudiant·e</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasStudent">cwrc:hasStudent</a>
    /// </summary>
    let hasStudent = _prefixId.prefix "hasStudent"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : has time certainty</para>
    ///   <para>skos:definition : skos:definition : Indicates the degree of certainty or precision of the temporal value or values associated with a time-based phenomenon such as an event or birth date</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasTimeCertainty">cwrc:hasTimeCertainty</a>
    /// </summary>
    let hasTimeCertainty = _prefixId.prefix "hasTimeCertainty"
    /// <summary>
    ///   <para>rdfs:label : has travellerrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasTraveller">cwrc:hasTraveller</a>
    /// </summary>
    let hasTraveller = _prefixId.prefix "hasTraveller"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Relates a person to the sister of their father or mother, but can also refer to any avuncular relationship and need not be restricted to a consanguineal relation.
    ///     </para>
    ///   <para>rdfs:label : has unclerdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasUncle">cwrc:hasUncle</a>
    /// </summary>
    let hasUncle = _prefixId.prefix "hasUncle"
    /// <summary>
    ///   <para>rdfs:label : has vistorrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasVistor">cwrc:hasVistor</a>
    /// </summary>
    let hasVistor = _prefixId.prefix "hasVistor"
    /// <summary>
    ///   <para>skos:definition : Indicates a regular role or activity that was voluntary rather than paid, including philanthropic activity.skos:definition : </para>
    ///   <para>rdfs:label : has volunteer occupationrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasVolunteerOccupation">cwrc:hasVolunteerOccupation</a>
    /// </summary>
    let hasVolunteerOccupation = _prefixId.prefix "hasVolunteerOccupation"
    /// <summary>
    ///   <para>rdfs:label : has wiferdfs:label : </para>
    ///   <para>skos:definition : skos:definition : Relates a person to a female-identified partner in a marital relationship.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#hasWife">cwrc:hasWife</a>
    /// </summary>
    let hasWife = _prefixId.prefix "hasWife"
    let headOfState = _prefixId.prefix "headOfState"
    let healthCareProvider = _prefixId.prefix "healthCareProvider"
    let hermeticism = _prefixId.prefix "hermeticism"
    let heterosexual = _prefixId.prefix "heterosexual"
    let highCertainty = _prefixId.prefix "highCertainty"
    let highChurchParty = _prefixId.prefix "highChurchParty"
    let highToryism = _prefixId.prefix "highToryism"
    let higherGovernment = _prefixId.prefix "higherGovernment"
    let hinduism = _prefixId.prefix "hinduism"
    let historian = _prefixId.prefix "historian"
    let homeRule = _prefixId.prefix "homeRule"
    let homosexual = _prefixId.prefix "homosexual"
    let honoraryDegree = _prefixId.prefix "honoraryDegree"
    let hospitality = _prefixId.prefix "hospitality"
    let hostess = _prefixId.prefix "hostess"
    let housePainter = _prefixId.prefix "housePainter"
    let houseSitter = _prefixId.prefix "houseSitter"
    let housekeeper = _prefixId.prefix "housekeeper"
    let housework = _prefixId.prefix "housework"
    let housingMovement = _prefixId.prefix "housingMovement"
    let huguenotNationalHeritage = _prefixId.prefix "huguenotNationalHeritage"
    let humanRights = _prefixId.prefix "humanRights"
    let humanism = _prefixId.prefix "humanism"
    let humanitarianWork = _prefixId.prefix "humanitarianWork"
    let hunter = _prefixId.prefix "hunter"
    /// <summary>
    ///   <para>rdfs:label : husband ofrdfs:label : mari de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#husbandOf">cwrc:husbandOf</a>
    /// </summary>
    let husbandOf = _prefixId.prefix "husbandOf"
    let hypnotist = _prefixId.prefix "hypnotist"
    let identity = _prefixId.prefix "identity"
    let igboEthnicity = _prefixId.prefix "igboEthnicity"
    let illustrator = _prefixId.prefix "illustrator"
    let immunologist = _prefixId.prefix "immunologist"
    let imperialism = _prefixId.prefix "imperialism"
    let inRole = _prefixId.prefix "inRole"
    let independentMethodistConnexion = _prefixId.prefix "independentMethodistConnexion"
    /// <summary>
    ///   <para>skos:definition : Indicates an organization's use of this name form in its index.skos:definition : </para>
    ///   <para>rdfs:label : indexed byrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#indexedBy">cwrc:indexedBy</a>
    /// </summary>
    let indexedBy = _prefixId.prefix "indexedBy"
    let indianIndependence = _prefixId.prefix "indianIndependence"
    let indianRaceColour = _prefixId.prefix "indianRaceColour"
    let indianUnification = _prefixId.prefix "indianUnification"

    let indigenousPeoplesOfAmericasEthnicity = _prefixId.prefix "indigenousPeoplesOfAmericasEthnicity"

    let indigenousPeoplesOfAmericasRaceColour = _prefixId.prefix "indigenousPeoplesOfAmericasRaceColour"

    let indigenousRights = _prefixId.prefix "indigenousRights"
    let indigent = _prefixId.prefix "indigent"
    let individualism = _prefixId.prefix "individualism"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Indicates that a person lived in this place.</para>
    ///   <para>rdfs:label : inhabitedrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#inhabits">cwrc:inhabits</a>
    /// </summary>
    let inhabits = _prefixId.prefix "inhabits"
    let insurance = _prefixId.prefix "insurance"
    let intellectual = _prefixId.prefix "intellectual"
    let intelligenceWork = _prefixId.prefix "intelligenceWork"
    let internationalism = _prefixId.prefix "internationalism"
    let interpersonalRelationship = _prefixId.prefix "interpersonalRelationship"
    let interviewer = _prefixId.prefix "interviewer"
    let inventor = _prefixId.prefix "inventor"
    let investor = _prefixId.prefix "investor"
    let irishEthnicity = _prefixId.prefix "irishEthnicity"
    let irishHomeRuleMovement = _prefixId.prefix "irishHomeRuleMovement"
    let irishNationalism = _prefixId.prefix "irishNationalism"
    let irishRepublicanism = _prefixId.prefix "irishRepublicanism"
    let irishUnionism = _prefixId.prefix "irishUnionism"
    let ironmaster = _prefixId.prefix "ironmaster"
    let ironmonger = _prefixId.prefix "ironmonger"
    let iroquoisNationalHeritage = _prefixId.prefix "iroquoisNationalHeritage"
    let islam = _prefixId.prefix "islam"
    let isolationism = _prefixId.prefix "isolationism"
    let italianNationalism = _prefixId.prefix "italianNationalism"
    let italianUnification = _prefixId.prefix "italianUnification"
    let jacobinism = _prefixId.prefix "jacobinism"
    let jacobism = _prefixId.prefix "jacobism"
    let jacobitism = _prefixId.prefix "jacobitism"
    let jamaicanEthnicity = _prefixId.prefix "jamaicanEthnicity"
    let jansenism = _prefixId.prefix "jansenism"
    let jeweller = _prefixId.prefix "jeweller"
    let jewishEmancipation = _prefixId.prefix "jewishEmancipation"
    let jewishEthnicity = _prefixId.prefix "jewishEthnicity"
    let jewishGeographicHeritage = _prefixId.prefix "jewishGeographicHeritage"
    let jewishLabel = _prefixId.prefix "jewishLabel"
    let jewishNationalHeritage = _prefixId.prefix "jewishNationalHeritage"
    let jewishNationalIdentity = _prefixId.prefix "jewishNationalIdentity"
    let jewishRaceColour = _prefixId.prefix "jewishRaceColour"
    let jewishReligion = _prefixId.prefix "jewishReligion"
    let journalist = _prefixId.prefix "journalist"
    let judaism = _prefixId.prefix "judaism"
    let judge = _prefixId.prefix "judge"
    let knight = _prefixId.prefix "knight"
    let labourMovement = _prefixId.prefix "labourMovement"
    let labourUnion = _prefixId.prefix "labourUnion"
    let ladyLiterateInArts = _prefixId.prefix "ladyLiterateInArts"
    let landReform = _prefixId.prefix "landReform"
    let latitudinarianism = _prefixId.prefix "latitudinarianism"
    let laundryWorker = _prefixId.prefix "laundryWorker"
    let lawDegree = _prefixId.prefix "lawDegree"
    let lawEnforcement = _prefixId.prefix "lawEnforcement"
    let lawyer = _prefixId.prefix "lawyer"
    let leatherWorker = _prefixId.prefix "leatherWorker"
    let left_Wing = _prefixId.prefix "left-Wing"
    let legalWork = _prefixId.prefix "legalWork"
    let lesbian = _prefixId.prefix "lesbian"
    let lesbianFeminism = _prefixId.prefix "lesbianFeminism"
    let liaisonOfficer = _prefixId.prefix "liaisonOfficer"
    let liberalUnionistParty = _prefixId.prefix "liberalUnionistParty"
    let liberalism = _prefixId.prefix "liberalism"
    let libertarianism = _prefixId.prefix "libertarianism"
    let librarian = _prefixId.prefix "librarian"
    let lifeScientist = _prefixId.prefix "lifeScientist"
    let linguist = _prefixId.prefix "linguist"
    /// <summary>
    ///   <para>rdfs:label : language known ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityOf">cwrc:linguisticAbilityOf</a>
    /// </summary>
    let linguisticAbilityOf = _prefixId.prefix "linguisticAbilityOf"
    /// <summary>
    ///   <para>rdfs:label : language known (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilityReportedOf">cwrc:linguisticAbilityReportedOf</a>
    /// </summary>
    let linguisticAbilityReportedOf = _prefixId.prefix "linguisticAbilityReportedOf"

    /// <summary>
    ///   <para>rdfs:label : language known (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#linguisticAbilitySelfReportedOf">cwrc:linguisticAbilitySelfReportedOf</a>
    /// </summary>
    let linguisticAbilitySelfReportedOf = _prefixId.prefix "linguisticAbilitySelfReportedOf"

    let literalForm = _prefixId.prefix "literalForm"
    let literaryAgent = _prefixId.prefix "literaryAgent"
    let literaryAssistant = _prefixId.prefix "literaryAssistant"
    let literaryConservationist = _prefixId.prefix "literaryConservationist"
    let literaryExecutor = _prefixId.prefix "literaryExecutor"
    let literaryForger = _prefixId.prefix "literaryForger"
    let literaryGroupParticipant = _prefixId.prefix "literaryGroupParticipant"
    let literaryPrizeAdjudicator = _prefixId.prefix "literaryPrizeAdjudicator"
    let literaryScholar = _prefixId.prefix "literaryScholar"
    let lithographer = _prefixId.prefix "lithographer"
    let litigant = _prefixId.prefix "litigant"
    let lobbyist = _prefixId.prefix "lobbyist"
    let localGovernment = _prefixId.prefix "localGovernment"
    /// <summary>
    ///   <para>skos:definition : Things that are or were at this location at some point in time.skos:definition : </para>
    ///   <para>rdfs:label : location Ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#locationOf">cwrc:locationOf</a>
    /// </summary>
    let locationOf = _prefixId.prefix "locationOf"
    let logger = _prefixId.prefix "logger"
    let lollards = _prefixId.prefix "lollards"
    let lollardy = _prefixId.prefix "lollardy"
    let lordChamberlain = _prefixId.prefix "lordChamberlain"
    let lordChancellor = _prefixId.prefix "lordChancellor"
    let lowCertainty = _prefixId.prefix "lowCertainty"
    let lowerMiddleClass = _prefixId.prefix "lowerMiddleClass"
    let machineWork = _prefixId.prefix "machineWork"
    /// <summary>
    ///   <para>rdfs:label : made alterationrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : Links an &lt;a href="#ChangeSet" title="#ChangeSet"&gt;change set&lt;/a&gt; to a &lt;a href="#NaturalPerson" title="#NaturalPerson"&gt;natural person&lt;/a&gt;</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#madeAlteration">cwrc:madeAlteration</a>
    /// </summary>
    let madeAlteration = _prefixId.prefix "madeAlteration"
    let magistrate = _prefixId.prefix "magistrate"
    let maidOfHonour = _prefixId.prefix "maidOfHonour"
    let maleLabel = _prefixId.prefix "maleLabel"
    let maleSex = _prefixId.prefix "maleSex"
    let malthusianism = _prefixId.prefix "malthusianism"
    let man = _prefixId.prefix "man"
    let manLabel = _prefixId.prefix "manLabel"
    let manager = _prefixId.prefix "manager"
    let managerial = _prefixId.prefix "managerial"
    let manservant = _prefixId.prefix "manservant"
    let manualLabourer = _prefixId.prefix "manualLabourer"
    let manufacturer = _prefixId.prefix "manufacturer"
    let maoism = _prefixId.prefix "maoism"
    let mapping = _prefixId.prefix "mapping"
    let marriageLawReform = _prefixId.prefix "marriageLawReform"
    let martyr = _prefixId.prefix "martyr"
    let marxism = _prefixId.prefix "marxism"
    let mason = _prefixId.prefix "mason"
    let masterOfTheRevels = _prefixId.prefix "masterOfTheRevels"
    let mastersDegree = _prefixId.prefix "mastersDegree"
    let mathematics = _prefixId.prefix "mathematics"
    let matron = _prefixId.prefix "matron"
    let mayor = _prefixId.prefix "mayor"
    let medicalDegree = _prefixId.prefix "medicalDegree"
    let medicalDoctor = _prefixId.prefix "medicalDoctor"
    let mediumCertainty = _prefixId.prefix "mediumCertainty"
    let memberOfParliament = _prefixId.prefix "memberOfParliament"
    let mentalHealthProfessional = _prefixId.prefix "mentalHealthProfessional"
    let mentor = _prefixId.prefix "mentor"
    let mercer = _prefixId.prefix "mercer"
    let merchant = _prefixId.prefix "merchant"
    let merchantTaylor = _prefixId.prefix "merchantTaylor"
    let metalWork = _prefixId.prefix "metalWork"
    let metallurgy = _prefixId.prefix "metallurgy"
    let meteorologist = _prefixId.prefix "meteorologist"
    let methodism = _prefixId.prefix "methodism"
    let methodistEpiscopalian = _prefixId.prefix "methodistEpiscopalian"
    let middleChild = _prefixId.prefix "middleChild"
    let middleClass = _prefixId.prefix "middleClass"
    let midwife = _prefixId.prefix "midwife"
    /// <summary>
    ///   <para>skos:definition : skos:definition : Indicates that a person migrated from this place.</para>
    ///   <para>rdfs:label : rdfs:label : emigrated from</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#migratesFrom">cwrc:migratesFrom</a>
    /// </summary>
    let migratesFrom = _prefixId.prefix "migratesFrom"
    /// <summary>
    ///   <para>rdfs:label : immigrated tordfs:label : </para>
    ///   <para>skos:definition : Indicates that a person immigrated to this place.skos:definition : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#migratesTo">cwrc:migratesTo</a>
    /// </summary>
    let migratesTo = _prefixId.prefix "migratesTo"
    let militarism = _prefixId.prefix "militarism"
    let military = _prefixId.prefix "military"
    let millenarianism = _prefixId.prefix "millenarianism"
    let miller = _prefixId.prefix "miller"
    let milliner = _prefixId.prefix "milliner"
    let miner = _prefixId.prefix "miner"
    let mining = _prefixId.prefix "mining"
    let miscarriage = _prefixId.prefix "miscarriage"
    let miser = _prefixId.prefix "miser"
    let missionaryWork = _prefixId.prefix "missionaryWork"
    let mistress = _prefixId.prefix "mistress"
    let mixedRaceColour = _prefixId.prefix "mixedRaceColour"
    let model = _prefixId.prefix "model"
    let mohawkNationalHeritage = _prefixId.prefix "mohawkNationalHeritage"
    let mohawkNationalIdentity = _prefixId.prefix "mohawkNationalIdentity"
    let monarch = _prefixId.prefix "monarch"
    let monarchism = _prefixId.prefix "monarchism"
    let monism = _prefixId.prefix "monism"
    let moravian = _prefixId.prefix "moravian"
    /// <summary>
    ///   <para>rdfs:label : mother ofrdfs:label : mère de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#motherOf">cwrc:motherOf</a>
    /// </summary>
    let motherOf = _prefixId.prefix "motherOf"
    let mountaineering = _prefixId.prefix "mountaineering"
    let multiculturalism = _prefixId.prefix "multiculturalism"
    let multiracialism = _prefixId.prefix "multiracialism"
    let munitionsWorker = _prefixId.prefix "munitionsWorker"
    let music = _prefixId.prefix "music"
    let musicologist = _prefixId.prefix "musicologist"
    let mysticism = _prefixId.prefix "mysticism"
    /// <summary>
    ///   <para>rdfs:label : national heritage ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageOf">cwrc:nationalHeritageOf</a>
    /// </summary>
    let nationalHeritageOf = _prefixId.prefix "nationalHeritageOf"
    /// <summary>
    ///   <para>rdfs:label : national heritage (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageReportedOf">cwrc:nationalHeritageReportedOf</a>
    /// </summary>
    let nationalHeritageReportedOf = _prefixId.prefix "nationalHeritageReportedOf"

    /// <summary>
    ///   <para>rdfs:label : national heritage (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nationalHeritageSelfReportedOf">cwrc:nationalHeritageSelfReportedOf</a>
    /// </summary>
    let nationalHeritageSelfReportedOf = _prefixId.prefix "nationalHeritageSelfReportedOf"

    let nationalism = _prefixId.prefix "nationalism"
    /// <summary>
    ///   <para>rdfs:label : national identity ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nationalityOf">cwrc:nationalityOf</a>
    /// </summary>
    let nationalityOf = _prefixId.prefix "nationalityOf"
    /// <summary>
    ///   <para>rdfs:label : national identity (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nationalityReportedOf">cwrc:nationalityReportedOf</a>
    /// </summary>
    let nationalityReportedOf = _prefixId.prefix "nationalityReportedOf"
    /// <summary>
    ///   <para>rdfs:label : national identity (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nationalitySelfReportedOf">cwrc:nationalitySelfReportedOf</a>
    /// </summary>
    let nationalitySelfReportedOf = _prefixId.prefix "nationalitySelfReportedOf"
    /// <summary>
    ///   <para>rdfs:label : natively known language ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityOf">cwrc:nativeLinguisticAbilityOf</a>
    /// </summary>
    let nativeLinguisticAbilityOf = _prefixId.prefix "nativeLinguisticAbilityOf"

    /// <summary>
    ///   <para>rdfs:label : natively known language (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilityReportedOf">cwrc:nativeLinguisticAbilityReportedOf</a>
    /// </summary>
    let nativeLinguisticAbilityReportedOf = _prefixId.prefix "nativeLinguisticAbilityReportedOf"

    /// <summary>
    ///   <para>rdfs:label : natively known language (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nativeLinguisticAbilitySelfReportedOf">cwrc:nativeLinguisticAbilitySelfReportedOf</a>
    /// </summary>
    let nativeLinguisticAbilitySelfReportedOf = _prefixId.prefix "nativeLinguisticAbilitySelfReportedOf"

    let naturalReligion = _prefixId.prefix "naturalReligion"
    let naturalist = _prefixId.prefix "naturalist"
    let navy = _prefixId.prefix "navy"
    let nazism = _prefixId.prefix "nazism"
    let needlework = _prefixId.prefix "needlework"
    let neo_Conservatism = _prefixId.prefix "neo-Conservatism"
    let neo_thomism = _prefixId.prefix "neo-thomism"
    /// <summary>
    ///   <para>rdfs:label : neveu derdfs:label : nephew of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nephewOf">cwrc:nephewOf</a>
    /// </summary>
    let nephewOf = _prefixId.prefix "nephewOf"
    let newDealer = _prefixId.prefix "newDealer"
    let newThought = _prefixId.prefix "newThought"
    let newUnionism = _prefixId.prefix "newUnionism"
    /// <summary>
    ///   <para>rdfs:label : nièce derdfs:label : niece of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#nieceOf">cwrc:nieceOf</a>
    /// </summary>
    let nieceOf = _prefixId.prefix "nieceOf"
    let nihilism = _prefixId.prefix "nihilism"
    let nobility = _prefixId.prefix "nobility"
    let nonjurorsMovement = _prefixId.prefix "nonjurorsMovement"
    let normanNationalHeritage = _prefixId.prefix "normanNationalHeritage"
    let numismatist = _prefixId.prefix "numismatist"
    let nun = _prefixId.prefix "nun"
    let nursing = _prefixId.prefix "nursing"
    let obeah = _prefixId.prefix "obeah"
    let occultism = _prefixId.prefix "occultism"
    /// <summary>
    ///   <para>rdfs:label : occupation income ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#occupationIncomeOf">cwrc:occupationIncomeOf</a>
    /// </summary>
    let occupationIncomeOf = _prefixId.prefix "occupationIncomeOf"
    /// <summary>
    ///   <para>rdfs:label : occupation ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#occupationOf">cwrc:occupationOf</a>
    /// </summary>
    let occupationOf = _prefixId.prefix "occupationOf"
    let onlyChild = _prefixId.prefix "onlyChild"
    let oppositionPolitics = _prefixId.prefix "oppositionPolitics"
    let optician = _prefixId.prefix "optician"
    let orderly = _prefixId.prefix "orderly"
    let originalOrlandoAuthor = _prefixId.prefix "originalOrlandoAuthor"
    let orphanageWork = _prefixId.prefix "orphanageWork"
    let pacifism = _prefixId.prefix "pacifism"
    let pacifist = _prefixId.prefix "pacifist"
    let pagan = _prefixId.prefix "pagan"
    let paganism = _prefixId.prefix "paganism"
    /// <summary>
    ///   <para>rdfs:label : paid occupation ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#paidOccupationOf">cwrc:paidOccupationOf</a>
    /// </summary>
    let paidOccupationOf = _prefixId.prefix "paidOccupationOf"
    let pantheism = _prefixId.prefix "pantheism"
    /// <summary>
    ///   <para>rdfs:label : parent ofrdfs:label : parent de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#parentOf">cwrc:parentOf</a>
    /// </summary>
    let parentOf = _prefixId.prefix "parentOf"
    let parishWork = _prefixId.prefix "parishWork"
    let parliamentarianism = _prefixId.prefix "parliamentarianism"
    let parliamentaryReform = _prefixId.prefix "parliamentaryReform"
    let parsiEthnicity = _prefixId.prefix "parsiEthnicity"
    /// <summary>
    ///   <para>skos:definition : skos:definition : The event that the Person is associated with.</para>
    ///   <para>rdfs:label : participant ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#participantOf">cwrc:participantOf</a>
    /// </summary>
    let participantOf = _prefixId.prefix "participantOf"
    /// <summary>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <para>rdfs:label : partner ofrdfs:label : conjoint de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#partnerOf">cwrc:partnerOf</a>
    /// </summary>
    let partnerOf = _prefixId.prefix "partnerOf"
    let paternalism = _prefixId.prefix "paternalism"
    let patriot = _prefixId.prefix "patriot"
    let patriotism = _prefixId.prefix "patriotism"
    let patron = _prefixId.prefix "patron"
    let pawnbroker = _prefixId.prefix "pawnbroker"
    let pentecostalism = _prefixId.prefix "pentecostalism"
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <para>rdfs:label : persona ofrdfs:label : persona de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#personaOf">cwrc:personaOf</a>
    /// </summary>
    let personaOf = _prefixId.prefix "personaOf"
    let personalProperty = _prefixId.prefix "personalProperty"
    let personalPropertySelfDeclared = _prefixId.prefix "personalPropertySelfDeclared"
    let personalPropertySelfReported = _prefixId.prefix "personalPropertySelfReported"
    let pharmacist = _prefixId.prefix "pharmacist"
    let philanthropicVisitor = _prefixId.prefix "philanthropicVisitor"
    let philanthropist = _prefixId.prefix "philanthropist"
    let philosopher = _prefixId.prefix "philosopher"
    let philosophicalRadicals = _prefixId.prefix "philosophicalRadicals"
    let photography = _prefixId.prefix "photography"
    let physiognomist = _prefixId.prefix "physiognomist"
    let pilot = _prefixId.prefix "pilot"
    let plumber = _prefixId.prefix "plumber"
    let plymouthBrethren = _prefixId.prefix "plymouthBrethren"
    let poetLaureate = _prefixId.prefix "poetLaureate"
    let polishNationalism = _prefixId.prefix "polishNationalism"
    /// <summary>
    ///   <para>rdfs:label : political affiliation ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationOf">cwrc:politicalAffiliationOf</a>
    /// </summary>
    let politicalAffiliationOf = _prefixId.prefix "politicalAffiliationOf"

    /// <summary>
    ///   <para>rdfs:label : political affiliation (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationReportedOf">cwrc:politicalAffiliationReportedOf</a>
    /// </summary>
    let politicalAffiliationReportedOf = _prefixId.prefix "politicalAffiliationReportedOf"

    /// <summary>
    ///   <para>rdfs:label : political affiliation (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#politicalAffiliationSelfReportedOf">cwrc:politicalAffiliationSelfReportedOf</a>
    /// </summary>
    let politicalAffiliationSelfReportedOf = _prefixId.prefix "politicalAffiliationSelfReportedOf"

    let politicalHost = _prefixId.prefix "politicalHost"
    let politicalScience = _prefixId.prefix "politicalScience"
    let politicalSpeaker = _prefixId.prefix "politicalSpeaker"
    let politics = _prefixId.prefix "politics"
    let pollster = _prefixId.prefix "pollster"
    let poorAdvocacy = _prefixId.prefix "poorAdvocacy"
    let poorLawReform = _prefixId.prefix "poorLawReform"
    let pornographer = _prefixId.prefix "pornographer"
    let postalWorker = _prefixId.prefix "postalWorker"
    let postgraduateDegree = _prefixId.prefix "postgraduateDegree"
    let pottery = _prefixId.prefix "pottery"
    /// <summary>
    ///   <para>skos:definition : Indicates the authority or institution by which the name form is preferred.skos:definition : </para>
    ///   <para>rdfs:label : preferred byrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#preferredBy">cwrc:preferredBy</a>
    /// </summary>
    let preferredBy = _prefixId.prefix "preferredBy"
    let presbyterianism = _prefixId.prefix "presbyterianism"
    let printing = _prefixId.prefix "printing"
    let prisonReform = _prefixId.prefix "prisonReform"
    let prisoner = _prefixId.prefix "prisoner"
    let pro_American = _prefixId.prefix "pro-American"
    let pro_BoerWar = _prefixId.prefix "pro-BoerWar"
    let pro_Catholicism = _prefixId.prefix "pro-Catholicism"
    let pro_Choice = _prefixId.prefix "pro-Choice"
    let pro_European = _prefixId.prefix "pro-European"
    let pro_Slavery = _prefixId.prefix "pro-Slavery"
    let producer = _prefixId.prefix "producer"
    let professional = _prefixId.prefix "professional"
    let professionalDegree = _prefixId.prefix "professionalDegree"
    let professor = _prefixId.prefix "professor"
    let propagandist = _prefixId.prefix "propagandist"
    let propertyAgent = _prefixId.prefix "propertyAgent"
    let propertyLawReform = _prefixId.prefix "propertyLawReform"
    let propertyOwner = _prefixId.prefix "propertyOwner"
    let prophet = _prefixId.prefix "prophet"
    let prospector = _prefixId.prefix "prospector"
    let protestantRule = _prefixId.prefix "protestantRule"
    let protestantism = _prefixId.prefix "protestantism"
    let protoZionism = _prefixId.prefix "protoZionism"
    let publicReader = _prefixId.prefix "publicReader"
    let publicSpeaker = _prefixId.prefix "publicSpeaker"
    let publishing = _prefixId.prefix "publishing"
    let punjabiEthnicity = _prefixId.prefix "punjabiEthnicity"
    let puritanism = _prefixId.prefix "puritanism"
    let quakerism = _prefixId.prefix "quakerism"
    let quakers = _prefixId.prefix "quakers"
    let queerLabel = _prefixId.prefix "queerLabel"
    /// <summary>
    ///   <para>rdfs:label : race or colour identity ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourOf">cwrc:raceColourOf</a>
    /// </summary>
    let raceColourOf = _prefixId.prefix "raceColourOf"
    /// <summary>
    ///   <para>rdfs:label : race or colour identity (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourReportedOf">cwrc:raceColourReportedOf</a>
    /// </summary>
    let raceColourReportedOf = _prefixId.prefix "raceColourReportedOf"
    /// <summary>
    ///   <para>rdfs:label : race or colour identity (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#raceColourSelfReportedOf">cwrc:raceColourSelfReportedOf</a>
    /// </summary>
    let raceColourSelfReportedOf = _prefixId.prefix "raceColourSelfReportedOf"
    let racialEquality = _prefixId.prefix "racialEquality"
    let racism = _prefixId.prefix "racism"
    let radicalism = _prefixId.prefix "radicalism"
    let radioIndustry = _prefixId.prefix "radioIndustry"
    let radioOperator = _prefixId.prefix "radioOperator"
    let railwayWork = _prefixId.prefix "railwayWork"
    /// <summary>
    ///   <para>skos:definition : Specifies a particular class type that is acceptable to use for a relation's rangeskos:definition : </para>
    ///   <para>rdfs:label : range includesrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#rangeIncludes">cwrc:rangeIncludes</a>
    /// </summary>
    let rangeIncludes = _prefixId.prefix "rangeIncludes"
    let rationalDissenter = _prefixId.prefix "rationalDissenter"
    let rationalism = _prefixId.prefix "rationalism"
    let reading = _prefixId.prefix "reading"
    let rebel = _prefixId.prefix "rebel"
    let redCross = _prefixId.prefix "redCross"
    let reformer = _prefixId.prefix "reformer"
    let refugee = _prefixId.prefix "refugee"
    let refugeeWork = _prefixId.prefix "refugeeWork"
    let regionalGovernment = _prefixId.prefix "regionalGovernment"
    let reincarnation = _prefixId.prefix "reincarnation"
    /// <summary>
    ///   <para>skos:definition : Indicates an entity's connection to a geospatial location.skos:definition : </para>
    ///   <para>rdfs:label : related spatially tordfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#relatesSpatiallyTo">cwrc:relatesSpatiallyTo</a>
    /// </summary>
    let relatesSpatiallyTo = _prefixId.prefix "relatesSpatiallyTo"
    /// <summary>
    ///   <para>rdfs:label : relative ofrdfs:label : liens de famille</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#relativeOf">cwrc:relativeOf</a>
    /// </summary>
    let relativeOf = _prefixId.prefix "relativeOf"
    let reliefWork = _prefixId.prefix "reliefWork"
    /// <summary>
    ///   <para>rdfs:label : religious affiliation ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#religionOf">cwrc:religionOf</a>
    /// </summary>
    let religionOf = _prefixId.prefix "religionOf"
    /// <summary>
    ///   <para>rdfs:label : religious affiliation (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#religionReportedOf">cwrc:religionReportedOf</a>
    /// </summary>
    let religionReportedOf = _prefixId.prefix "religionReportedOf"
    /// <summary>
    ///   <para>rdfs:label : religious affiliation (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#religionSelfReportedOf">cwrc:religionSelfReportedOf</a>
    /// </summary>
    let religionSelfReportedOf = _prefixId.prefix "religionSelfReportedOf"
    let religious = _prefixId.prefix "religious"
    let religiousOfficial = _prefixId.prefix "religiousOfficial"
    let religiousStudies = _prefixId.prefix "religiousStudies"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : moved to</para>
    ///   <para>skos:definition : skos:definition : Indicates that a person moved to this place.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#relocatesTo">cwrc:relocatesTo</a>
    /// </summary>
    let relocatesTo = _prefixId.prefix "relocatesTo"
    /// <summary>
    ///   <para>skos:definition : Relates ambiguous or overloaded terms, classed as &lt;a href="#TextLabels" title="#TextLabels"&gt;textual label&lt;/a&gt; to two or more particularly contested and related concepts. Often used for &lt;a href="#CulturalForm" title="#CulturalForm"&gt;cultural form&lt;/a&gt;; for instance ISO 3166-2:GB-ENG and &lt;a href="#englishNationalHeritage" title="#englishNationalHeritage"&gt;English&lt;/a&gt; are both represented by &lt;a href="#englishLabel" title="#englishLabel"&gt;English identity&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : represented byrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#representedBy">cwrc:representedBy</a>
    /// </summary>
    let representedBy = _prefixId.prefix "representedBy"
    /// <summary>
    ///   <para>skos:definition : Relates a concept to ambiguous or overloaded terms, classed as &lt;a href="#TextLabels" title="#TextLabels"&gt;textual label&lt;/a&gt;, that designate multivalent and frequently contested concepts.  For instance, &lt;a href="#englishLabel" title="#englishLabel"&gt;English identity&lt;/a&gt; is a &lt;a href="#TextLabels" title="#TextLabels"&gt;textual label&lt;/a&gt; that represents both ISO 3166-2:GB-ENG and &lt;a href="#englishNationalHeritage" title="#englishNationalHeritage"&gt;English&lt;/a&gt;.skos:definition : </para>
    ///   <para>rdfs:label : representsrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#represents">cwrc:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    let republicanism = _prefixId.prefix "republicanism"
    let rescueWork = _prefixId.prefix "rescueWork"
    let researcher = _prefixId.prefix "researcher"
    let retail = _prefixId.prefix "retail"
    let reviewer = _prefixId.prefix "reviewer"
    let revolutionaryPolitics = _prefixId.prefix "revolutionaryPolitics"
    let riding = _prefixId.prefix "riding"
    let romaniEthnicity = _prefixId.prefix "romaniEthnicity"
    let rosicrucianism = _prefixId.prefix "rosicrucianism"
    let rural_unskilled = _prefixId.prefix "rural-unskilled"
    let sabbatarianism = _prefixId.prefix "sabbatarianism"
    let sailor = _prefixId.prefix "sailor"
    let saint = _prefixId.prefix "saint"
    let salesperson = _prefixId.prefix "salesperson"
    let salter = _prefixId.prefix "salter"
    let sanitaryMovement = _prefixId.prefix "sanitaryMovement"
    let saxonNationalIdentity = _prefixId.prefix "saxonNationalIdentity"
    let scientist = _prefixId.prefix "scientist"
    let scottishEthnicity = _prefixId.prefix "scottishEthnicity"
    let scottishNationalism = _prefixId.prefix "scottishNationalism"
    let scottishRaceColour = _prefixId.prefix "scottishRaceColour"
    let seaCaptain = _prefixId.prefix "seaCaptain"
    let secondarySchoolDiploma = _prefixId.prefix "secondarySchoolDiploma"
    let secularism = _prefixId.prefix "secularism"
    let seekers = _prefixId.prefix "seekers"
    let separatism = _prefixId.prefix "separatism"
    let sephardicJewishEthnicity = _prefixId.prefix "sephardicJewishEthnicity"

    let sephardicJewishNationalIdentity = _prefixId.prefix "sephardicJewishNationalIdentity"

    let servant = _prefixId.prefix "servant"
    let servants = _prefixId.prefix "servants"
    let server = _prefixId.prefix "server"
    let settlementWork = _prefixId.prefix "settlementWork"
    let settler = _prefixId.prefix "settler"
    let sexWorker = _prefixId.prefix "sexWorker"
    let sexualReform = _prefixId.prefix "sexualReform"
    let sexualityBisexuality = _prefixId.prefix "sexualityBisexuality"
    let sexualityCelibacy = _prefixId.prefix "sexualityCelibacy"
    let sexualityFrigidity = _prefixId.prefix "sexualityFrigidity"
    let sexualityLibertinism = _prefixId.prefix "sexualityLibertinism"
    /// <summary>
    ///   <para>rdfs:label : sexual identity ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityOf">cwrc:sexualityOf</a>
    /// </summary>
    let sexualityOf = _prefixId.prefix "sexualityOf"
    let sexualityPromiscuity = _prefixId.prefix "sexualityPromiscuity"
    /// <summary>
    ///   <para>rdfs:label : sexual identity (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#sexualityReportedOf">cwrc:sexualityReportedOf</a>
    /// </summary>
    let sexualityReportedOf = _prefixId.prefix "sexualityReportedOf"
    /// <summary>
    ///   <para>rdfs:label : sexual identity (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#sexualitySelfReportedOf">cwrc:sexualitySelfReportedOf</a>
    /// </summary>
    let sexualitySelfReportedOf = _prefixId.prefix "sexualitySelfReportedOf"
    let shinto = _prefixId.prefix "shinto"
    let shipping = _prefixId.prefix "shipping"
    let shopkeepers = _prefixId.prefix "shopkeepers"
    /// <summary>
    ///   <para>rdfs:label : sibling ofrdfs:label : frères et soeurs de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#siblingOf">cwrc:siblingOf</a>
    /// </summary>
    let siblingOf = _prefixId.prefix "siblingOf"
    let singer = _prefixId.prefix "singer"
    /// <summary>
    ///   <para>rdfs:label : soeur derdfs:label : sister of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#sisterOf">cwrc:sisterOf</a>
    /// </summary>
    let sisterOf = _prefixId.prefix "sisterOf"
    let skilledCraftpersonArtisan = _prefixId.prefix "skilledCraftpersonArtisan"
    let skilledTrade = _prefixId.prefix "skilledTrade"
    let skinner = _prefixId.prefix "skinner"
    let slavEthnicity = _prefixId.prefix "slavEthnicity"
    let slave = _prefixId.prefix "slave"
    let slave_forced_labourer = _prefixId.prefix "slave-forced-labourer"
    let slaveOwner = _prefixId.prefix "slaveOwner"
    let slaver = _prefixId.prefix "slaver"
    let smuggler = _prefixId.prefix "smuggler"
    /// <summary>
    ///   <para>rdfs:label : class identity ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassOf">cwrc:socialClassOf</a>
    /// </summary>
    let socialClassOf = _prefixId.prefix "socialClassOf"
    /// <summary>
    ///   <para>rdfs:label : class identity (reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassReportedOf">cwrc:socialClassReportedOf</a>
    /// </summary>
    let socialClassReportedOf = _prefixId.prefix "socialClassReportedOf"
    /// <summary>
    ///   <para>rdfs:label : class identity (self-reported) ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#socialClassSelfReportedOf">cwrc:socialClassSelfReportedOf</a>
    /// </summary>
    let socialClassSelfReportedOf = _prefixId.prefix "socialClassSelfReportedOf"
    let socialGospel = _prefixId.prefix "socialGospel"
    let socialPurity = _prefixId.prefix "socialPurity"
    let socialReform = _prefixId.prefix "socialReform"
    let socialScientist = _prefixId.prefix "socialScientist"
    let socialWork = _prefixId.prefix "socialWork"
    let socialism = _prefixId.prefix "socialism"
    let socializer = _prefixId.prefix "socializer"
    let societyOfFriends = _prefixId.prefix "societyOfFriends"
    let socinianism = _prefixId.prefix "socinianism"
    /// <summary>
    ///   <para>rdfs:label : son ofrdfs:label : fil de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#sonOf">cwrc:sonOf</a>
    /// </summary>
    let sonOf = _prefixId.prefix "sonOf"
    let spanishRepublicanism = _prefixId.prefix "spanishRepublicanism"
    let spinner = _prefixId.prefix "spinner"
    let spiritualism = _prefixId.prefix "spiritualism"
    let sports = _prefixId.prefix "sports"
    let sshrc = _prefixId.prefix "sshrc"
    let stalinism = _prefixId.prefix "stalinism"
    let statelessNationalIdentity = _prefixId.prefix "statelessNationalIdentity"
    let statistician = _prefixId.prefix "statistician"
    /// <summary>
    ///   <para>rdfs:label : stepbrother ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepBrotherOf">cwrc:stepBrotherOf</a>
    /// </summary>
    let stepBrotherOf = _prefixId.prefix "stepBrotherOf"
    /// <summary>
    ///   <para>rdfs:label : stepchild ofrdfs:label : enfant d'un autre mariage</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepChildOf">cwrc:stepChildOf</a>
    /// </summary>
    let stepChildOf = _prefixId.prefix "stepChildOf"
    /// <summary>
    ///   <para>rdfs:label : belle-fille derdfs:label : stepdaughter of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepDaughterOf">cwrc:stepDaughterOf</a>
    /// </summary>
    let stepDaughterOf = _prefixId.prefix "stepDaughterOf"
    /// <summary>
    ///   <para>skos:definition : Une personne qui prend le rôle d'un père pour un enfant sans être son père biologique. Notez-bien l’ambiguïté avec le text français pour le rôle du mari d'une soeur or d'un frère.skos:definition : </para>
    ///   <para>rdfs:label : stepfather ofrdfs:label : beau-père de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepFatherOf">cwrc:stepFatherOf</a>
    /// </summary>
    let stepFatherOf = _prefixId.prefix "stepFatherOf"
    /// <summary>
    ///   <para>skos:definition : Une personne qui prend le rôle d'une mère pour un enfant sans être sa mère biologique. Notez-bien l’ambiguïté avec le text français pour le rôle de la femme d'une soeur or d'un frère.skos:definition : </para>
    ///   <para>rdfs:label : stepmother ofrdfs:label : belle-mère de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepMotherOf">cwrc:stepMotherOf</a>
    /// </summary>
    let stepMotherOf = _prefixId.prefix "stepMotherOf"
    /// <summary>
    ///   <para>rdfs:label : stepparent derdfs:label : stepparent of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepParentOf">cwrc:stepParentOf</a>
    /// </summary>
    let stepParentOf = _prefixId.prefix "stepParentOf"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : stepsister of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepSisterOf">cwrc:stepSisterOf</a>
    /// </summary>
    let stepSisterOf = _prefixId.prefix "stepSisterOf"
    /// <summary>
    ///   <para>rdfs:label : stepson ofrdfs:label : beau-fils de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#stepSonOf">cwrc:stepSonOf</a>
    /// </summary>
    let stepSonOf = _prefixId.prefix "stepSonOf"
    let stillbirth = _prefixId.prefix "stillbirth"
    let storyteller = _prefixId.prefix "storyteller"
    let student = _prefixId.prefix "student"
    /// <summary>
    ///   <para>skos:definition : skos:definition : </para>
    ///   <para>rdfs:label : studied byrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#studiedBy">cwrc:studiedBy</a>
    /// </summary>
    let studiedBy = _prefixId.prefix "studiedBy"
    /// <summary>
    ///   <para>skos:definition : Indicates a text studied by a person in the course of their education, whether formal or informal, institutional or domestic.skos:definition : </para>
    ///   <para>rdfs:label : studiesrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#studies">cwrc:studies</a>
    /// </summary>
    let studies = _prefixId.prefix "studies"
    let suffrage = _prefixId.prefix "suffrage"
    let sufism = _prefixId.prefix "sufism"
    let surveyor = _prefixId.prefix "surveyor"
    let swedenborgianism = _prefixId.prefix "swedenborgianism"
    let tailor = _prefixId.prefix "tailor"
    let tatarNationalHeritage = _prefixId.prefix "tatarNationalHeritage"
    let taxOfficial = _prefixId.prefix "taxOfficial"
    let taxResistance = _prefixId.prefix "taxResistance"
    let teacher = _prefixId.prefix "teacher"
    /// <summary>
    ///   <para>skos:definition : Indicates a subject, field, art, or skill taught by an instructor or educational organization.skos:definition : </para>
    ///   <para>rdfs:label : teaches educational subjectrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#teachesEducationalSubject">cwrc:teachesEducationalSubject</a>
    /// </summary>
    let teachesEducationalSubject = _prefixId.prefix "teachesEducationalSubject"
    let teachingQualification = _prefixId.prefix "teachingQualification"
    let technician = _prefixId.prefix "technician"
    let telephoneOperator = _prefixId.prefix "telephoneOperator"
    let televisionIndustry = _prefixId.prefix "televisionIndustry"
    let temperanceMovement = _prefixId.prefix "temperanceMovement"
    let textiles = _prefixId.prefix "textiles"
    let theatreWork = _prefixId.prefix "theatreWork"
    let theism = _prefixId.prefix "theism"
    let thracianEthnicity = _prefixId.prefix "thracianEthnicity"
    let timberTrade = _prefixId.prefix "timberTrade"
    /// <summary>
    ///   <para>rdfs:label : time certainty ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#timeCertaintyOf">cwrc:timeCertaintyOf</a>
    /// </summary>
    let timeCertaintyOf = _prefixId.prefix "timeCertaintyOf"
    let tinker = _prefixId.prefix "tinker"
    let toryPartyBritain = _prefixId.prefix "toryPartyBritain"
    let tourGuide = _prefixId.prefix "tourGuide"
    let tractarianMovement = _prefixId.prefix "tractarianMovement"
    let tradeUnionism = _prefixId.prefix "tradeUnionism"
    let trader = _prefixId.prefix "trader"
    let transGender = _prefixId.prefix "transGender"
    let transMan = _prefixId.prefix "transMan"
    let transWoman = _prefixId.prefix "transWoman"
    let transcriber = _prefixId.prefix "transcriber"
    let translator = _prefixId.prefix "translator"
    let transportationWork = _prefixId.prefix "transportationWork"
    let travelling = _prefixId.prefix "travelling"
    /// <summary>
    ///   <para>rdfs:label : travelled tordfs:label : </para>
    ///   <para>skos:definition : skos:definition : Indicates that a person travelled to this place.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#travelsTo">cwrc:travelsTo</a>
    /// </summary>
    let travelsTo = _prefixId.prefix "travelsTo"
    let treasurer = _prefixId.prefix "treasurer"
    let trustee = _prefixId.prefix "trustee"
    let typeSetter = _prefixId.prefix "typeSetter"
    /// <summary>
    ///   <para>rdfs:label : uncle ofrdfs:label : oncle de</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#uncleOf">cwrc:uncleOf</a>
    /// </summary>
    let uncleOf = _prefixId.prefix "uncleOf"
    let undefinedGender = _prefixId.prefix "undefinedGender"
    let undergraduateDegree = _prefixId.prefix "undergraduateDegree"
    let unitarianChurch = _prefixId.prefix "unitarianChurch"
    let unitarianism = _prefixId.prefix "unitarianism"
    let universalist = _prefixId.prefix "universalist"
    let unknownCertainty = _prefixId.prefix "unknownCertainty"
    let unknownSex = _prefixId.prefix "unknownSex"
    let unskilledLabourer = _prefixId.prefix "unskilledLabourer"

    let unspecifiedReproductiveHistory = _prefixId.prefix "unspecifiedReproductiveHistory"

    let upholsterer = _prefixId.prefix "upholsterer"
    let upper_middleClass = _prefixId.prefix "upper-middleClass"
    let urban_industrialUnskilled = _prefixId.prefix "urban-industrialUnskilled"
    let urbanPlanning = _prefixId.prefix "urbanPlanning"
    let urbanReform = _prefixId.prefix "urbanReform"
    let utilitarianism = _prefixId.prefix "utilitarianism"
    let vegetarianism = _prefixId.prefix "vegetarianism"
    let venerealDisease = _prefixId.prefix "venerealDisease"
    let veterinaryWork = _prefixId.prefix "veterinaryWork"
    let vintner = _prefixId.prefix "vintner"
    /// <summary>
    ///   <para>rdfs:label : visitsrdfs:label : </para>
    ///   <para>skos:definition : skos:definition : Indicates that a person visited this place.</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#visits">cwrc:visits</a>
    /// </summary>
    let visits = _prefixId.prefix "visits"
    let visualArtist = _prefixId.prefix "visualArtist"
    let vitalism = _prefixId.prefix "vitalism"
    let volunteer = _prefixId.prefix "volunteer"
    /// <summary>
    ///   <para>rdfs:label : volunteer occupation ofrdfs:label : </para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#volunteerOccupationOf">cwrc:volunteerOccupationOf</a>
    /// </summary>
    let volunteerOccupationOf = _prefixId.prefix "volunteerOccupationOf"
    let walking = _prefixId.prefix "walking"
    let warWork = _prefixId.prefix "warWork"
    let warehouseWork = _prefixId.prefix "warehouseWork"
    let watchmaker = _prefixId.prefix "watchmaker"
    let weaver = _prefixId.prefix "weaver"
    let welder = _prefixId.prefix "welder"
    let welshLabel = _prefixId.prefix "welshLabel"
    let welshNationalHeritage = _prefixId.prefix "welshNationalHeritage"
    let welshNationalism = _prefixId.prefix "welshNationalism"
    let wendishEthnicity = _prefixId.prefix "wendishEthnicity"
    let wesleyanism = _prefixId.prefix "wesleyanism"
    let westIndianEthnicity = _prefixId.prefix "westIndianEthnicity"
    let westIndianNationalHeritage = _prefixId.prefix "westIndianNationalHeritage"
    let wetNurse = _prefixId.prefix "wetNurse"
    let whaler = _prefixId.prefix "whaler"
    let whiggism = _prefixId.prefix "whiggism"
    let whiteEthnicity = _prefixId.prefix "whiteEthnicity"
    let whiteLabel = _prefixId.prefix "whiteLabel"
    let whiteRace = _prefixId.prefix "whiteRace"
    let whiteRaceColour = _prefixId.prefix "whiteRaceColour"
    let wife = _prefixId.prefix "wife"
    /// <summary>
    ///   <para>rdfs:label : femme derdfs:label : wife of</para>
    ///   <a href="http://sparql.cwrc.ca/ontologies/cwrc#wifeOf">cwrc:wifeOf</a>
    /// </summary>
    let wifeOf = _prefixId.prefix "wifeOf"
    let wilkite = _prefixId.prefix "wilkite"
    let witness = _prefixId.prefix "witness"
    let woman = _prefixId.prefix "woman"
    let womanLabel = _prefixId.prefix "womanLabel"
    let womanism = _prefixId.prefix "womanism"
    let womensEducationReform = _prefixId.prefix "womensEducationReform"
    let womensEmploymentReform = _prefixId.prefix "womensEmploymentReform"
    let womensEnfranchisement = _prefixId.prefix "womensEnfranchisement"
    let workingClass = _prefixId.prefix "workingClass"
    let writer = _prefixId.prefix "writer"
    let writerInResidence = _prefixId.prefix "writerInResidence"
    let writingGroupParticipant = _prefixId.prefix "writingGroupParticipant"
    let yeoman_farmer = _prefixId.prefix "yeoman-farmer"
    let yorkist = _prefixId.prefix "yorkist"
    let youngestChild = _prefixId.prefix "youngestChild"
    let zen = _prefixId.prefix "zen"
    let zionism = _prefixId.prefix "zionism"
    let zoroastrianism = _prefixId.prefix "zoroastrianism"
